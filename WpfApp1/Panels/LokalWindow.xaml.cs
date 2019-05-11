using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
    /// Interaction logic for LokalWindow2.xaml
    /// </summary>
    public partial class LokalWindow2 : Window, INotifyPropertyChanged
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
        private double _kapacitet;
        private string _opis;
        private string _id;
        
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
        public double Kapacitet
        {
            get
            {
                return _kapacitet;
            }
            set
            {
                if (value != _kapacitet)
                {
                    _kapacitet = value;
                    OnPropertyChanged("Kapacitet");
                }
            }
        }
        public LokalWindow2()
        {
            InitializeComponent();
            foreach(TipLokala tip  in MainWindow.TipoviLokala.Values)
            {
                cbTipLokala.Items.Add(tip.Ime);
            }
            foreach(Etiketa etiketa in MainWindow.Etikete.Values)
            {
                cbEtiketa.Items.Add(etiketa.Id);
            }

            this.DataContext = this;
        }

        private void BtnSacuvajLokal_Click(object sender, RoutedEventArgs e)
        {

            string id = tbId.Text;
            string ime = tbNaziv.Text;
            string opis = tbOpis.Text;
            bool dostupnoZaHendikepe = (bool)chbDostupanZaHendikepe.IsChecked;
            bool dozvoljenoPusenje = (bool)chbDozvoljenoPusenje.IsChecked;
            Cena kategorijaCene;
            if (cbKategorijaCena.Text.Equals("Niske"))
            {
                kategorijaCene = Cena.niske;
            }
            else if (cbKategorijaCena.Text.Equals("Srednje"))
            {
                kategorijaCene = Cena.srednje;
            }
            else if(cbKategorijaCena.Text.Equals("Visoke"))
            {
                kategorijaCene = Cena.visoke;

            }
            else
            {
                kategorijaCene = Cena.izuzetnoVisoke;
            }
            Alkohol sluzenjeAlkohola;
            if(cbSluzenjealkohola.Text.Equals("Ne sluzi"))
            {
                sluzenjeAlkohola = Alkohol.neSluzi;
            }
            else if(cbSluzenjealkohola.Text.Equals("Sluzi do 23"))
            {
                sluzenjeAlkohola = Alkohol.sluziDo11;
            }
            else
            {
                sluzenjeAlkohola = Alkohol.sluziKasnoNocu;
            }
            int kapacitet = Int32.Parse(tbKapacitet.Text);
            DateTime datumOtvaranja = dpDatumOtvaranja.DisplayDate;
            bool rezervacije = (bool)ChbRezervacije.IsChecked;
            Etiketa etiketa = MainWindow.Etikete[cbEtiketa.Text];
            TipLokala lokalTip = MainWindow.TipoviLokala[cbTipLokala.Text];
            Lokal lokal = new Lokal(id, ime, opis, dostupnoZaHendikepe, dozvoljenoPusenje, kategorijaCene, sluzenjeAlkohola, kapacitet, datumOtvaranja, rezervacije, etiketa, lokalTip);
            if (!MainWindow.Etikete.ContainsKey(lokal.Id))
            {
                MainWindow.Lokali.Add(lokal.Id, lokal);
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(@"C:\Users\Korisnik\Desktop\Etikete.txt", FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, MainWindow.Lokali);
                stream.Close();
            }
            else
            {
                // todo: sta raditi ako kljuc vec postoji kada dodajem etiketu
            }
        }
    }
}
