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
            TipLokala tip1 = new TipLokala("123", "tip1", "jako dobar lokal");
            Etiketa etiketa1 = new Etiketa("qwe","luda prica",new Color());

            
            l.Add(new Lokal("123", "qwe", "qweqweqweqweqweqweqwe", true, true,Cena.izuzetnoVisoke, Alkohol.neSluzi, 10, date1, true,etiketa1,tip1));
            l.Add(new Lokal("124", "qwe", "qweqweqweqweqweqweqwe123", true, true, Cena.izuzetnoVisoke, Alkohol.neSluzi, 10, date1, true,etiketa1,tip1));
            l.Add(new Lokal("125", "qweREW", "qweqweqweqweqweqweqwe543", true, true, Cena.izuzetnoVisoke, Alkohol.neSluzi, 10, date1, true,etiketa1,tip1));
            Lokali = new ObservableCollection<Lokal>(l);

            View = CollectionViewSource.GetDefaultView(Lokali);
            GroupView = false;
        }
    }
}
