using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Models;

namespace WpfApp1.Panels
{
    /// <summary>
    /// Interaction logic for Tabela.xaml
    /// </summary>
    public partial class Tabela : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        private bool _GroupView;
        public bool GroupView
        {
            get
            {
                return _GroupView;
            }
            set
            {
                if (value != _GroupView && View != null)
                {
                    View.GroupDescriptions.Clear();
                    if (value)
                    {
                        View.GroupDescriptions.Add(new PropertyGroupDescription("Upisan"));
                    }
                    _GroupView = value;
                    OnPropertyChanged("GroupView");

                    OnPropertyChanged("View");
                }
            }
        }
        private ICollectionView _View;
        public ICollectionView View
        {
            get
            {
                return _View;
            }
            set
            {
                _View = value;
                OnPropertyChanged("View");
            }
        }
        public ObservableCollection<Lokal> Lokali
        {
            get;
            set;
        }
        public Tabela()
        {
            InitializeComponent();
            this.DataContext = this;
            List<Lokal> l = new List<Lokal>();
            DateTime date1 = new DateTime(2008, 6, 1, 2, 47, 0);
            DateTime date2 = new DateTime(2005, 8, 6, 4, 47, 0);
            DateTime date3 = new DateTime(2007, 4, 2, 1, 47, 0);
            TipLokala tip1 = new TipLokala("A163FK", "Restoran", "Restoran sa tradicionalnom spanskom kuhinjom",null);
            TipLokala tip2 = new TipLokala("A143LA", "Poslasticarnica", "Poslasticarnica sa najcarobnijim slatisima",null);
            TipLokala tip3 = new TipLokala("A153FO", "Kafic", "Svi vole kafu zato dodjite kod nas",null);
            Etiketa etiketa1 = new Etiketa("Q402RE", "Etiketa koja ima ulogu etikete", new Color());


            l.Add(new Lokal("P542TJ", "Vitraz", "Jedan od najboljh restorana", true, true, Cena.izuzetnoVisoke, Alkohol.neSluzi, 10, date1, true, etiketa1, tip1));
            l.Add(new Lokal("Q432PL", "Modena", "Kafic izvanrednih mogucnosti", true, true, Cena.izuzetnoVisoke, Alkohol.neSluzi, 10, date1, true, etiketa1, tip2));
            l.Add(new Lokal("T640GH", "Bistro", "Mozda i najjace mesto u gradu", true, true, Cena.izuzetnoVisoke, Alkohol.neSluzi, 10, date1, true, etiketa1, tip3));
            Lokali = new ObservableCollection<Lokal>(l);

            View = CollectionViewSource.GetDefaultView(Lokali);
            GroupView = false;
        }
    }
}
