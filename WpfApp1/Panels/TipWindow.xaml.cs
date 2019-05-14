using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
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
    /// Interaction logic for TipWindow.xaml
    /// </summary>
    public partial class TipWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        private string _naziv;
        private string _opis;
        private string _id;
        private string _ikonica;

        public string Ikonica
        {
            get { return _ikonica; }
            set { _ikonica = value; }
        }


        public string Naziv
        {
            get
            {
                return _naziv;
            }
            set
            {
                if (value != _naziv)
                {
                    _naziv = value;
                    OnPropertyChanged("Naziv");
                }
            }
        }
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        public string Opis
        {
            get
            {
                return _opis;
            }
            set
            {
                if (value != _opis)
                {
                    _opis = value;
                    OnPropertyChanged("Opis");
                }
            }
        }
        public TipWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        private void choseIcon(object sender,RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Ikonica = ofd.FileName;
                    
                }
                catch(SecurityException ex)
                {
                    System.Windows.MessageBox.Show("Ne moze");
                }
            }

        }

        private void saveTip(object sender, RoutedEventArgs e)
        {
            int flag = 1;
            if (String.IsNullOrEmpty(tbId.Text))
            {
                tbId.Background = new SolidColorBrush(Color.FromArgb(100, 255, 0, 0));
                flag = 0;



            }
            
            if (String.IsNullOrEmpty(tbOpis.Text))
            {
                tbOpis.Background = new SolidColorBrush(Color.FromArgb(100, 255, 0, 0));
                flag = 0;



            }

            if (String.IsNullOrEmpty(tbNaziv.Text))
            {
                tbNaziv.Background = new SolidColorBrush(Color.FromArgb(100, 255, 0, 0));
                flag = 0;



            }
            string ikonica;
            if (String.IsNullOrEmpty(Ikonica))
            {
                // todo: default ikonica za tipLokala
                ikonica = "asd";
            }
            else
            {
                ikonica = Ikonica;
            }
            string id = tbId.Text;
            string opis = tbOpis.Text;
            string ime = tbNaziv.Text;
            
            TipLokala tipLokala = new TipLokala(id, ime, opis,ikonica);
            if (!MainWindow.TipoviLokala.ContainsKey(tipLokala.Id))
            {
                MainWindow.TipoviLokala.Add(tipLokala.Id, tipLokala);
                BinaryWriter bw;
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(@"C:\Users\Korisnik\Desktop\TipoviLokala.txt", FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, MainWindow.TipoviLokala);
                stream.Close();
            }
            else
            {
                // todo: sta raditi ako kljuc vec postoji kada dodajem tip lokala
            }
            



        }
    }
}
