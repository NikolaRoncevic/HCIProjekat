using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
   public enum Cena { niske, srednje, visoke, izuzetnoVisoke };
   public enum Alkohol { neSluzi,sluziDo11,sluziKasnoNocu};
   public class Lokal : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        private string _id;
        private string _ime;
        private string _opis;
        private bool _dostupnoZaHendikepe;
        private bool _dozvoljenoPusenje;
        private Cena _kategorijaCena;
        private Alkohol _sluzenjeAlkohola;
        private int _kapacitet;
        private DateTime _datumOtvaranja;
        private bool _rezervacije;
        private Etiketa _etiketa;
        private TipLokala _lokalTip;

        

        

        public Lokal(string id,
            string ime, 
            string opis, 
            bool dostupnoZaHendikepe, 
            bool dozvoljenoPusenje, 
            Cena kategorijaCena, 
            Alkohol sluzenjeAlkohola, 
            int kapacitet, 
            DateTime datumOtvaranja, 
            bool rezervacije,
            Etiketa etiketa,
            TipLokala lokalTip
            )
        { 
            Id = id;
            Ime = ime;
            Opis = opis;
            DostupnoZaHendikepe = dostupnoZaHendikepe;
            DozvoljenoPusenje = dozvoljenoPusenje;
            KategorijaCena = kategorijaCena;
            SluzenjeAlkohola = sluzenjeAlkohola;
            Kapacitet = kapacitet;
            DatumOtvaranja = datumOtvaranja;
            Rezervacije = rezervacije;
            Etiketa = etiketa;
            LokalaTip = lokalTip;
        }

        public string Id
        {
            get { return _id; }
            set
            {
                if(value != _id)
                {
                    _id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        public Etiketa Etiketa
        {
            get { return _etiketa; }
            set
            {
                if (value != _etiketa)
                {
                    _etiketa = value;
                    OnPropertyChanged("Etiketa");
                }
            }
        }
        public TipLokala LokalaTip
        {
            get { return _lokalTip; }
            set
            {
                if (value != _lokalTip)
                {
                    _lokalTip = value;
                    OnPropertyChanged("LokalTip");
                }
            }
        }

        public string Ime
        {
            get { return _ime; }
            set
            {
                if (value != _ime)
                {
                    _ime = value;
                    OnPropertyChanged("Ime");
                }
            }
        }

        public string Opis
        {
            get { return _opis; }
            set
            {
                if (value != _opis)
                {
                    _opis = value;
                    OnPropertyChanged("Opis");
                }
            }
        }

        public bool DostupnoZaHendikepe
        {
            get { return _dostupnoZaHendikepe; }
            set
            {
                if (value != _dostupnoZaHendikepe)
                {
                    _dostupnoZaHendikepe = value;
                    OnPropertyChanged("DostupnoZaHendikepe");
                }
            }
        }
        
        public bool DozvoljenoPusenje
        {
            get { return _dozvoljenoPusenje; }
            set
            {
                if (value != _dozvoljenoPusenje)
                {
                    _dozvoljenoPusenje = value;
                    OnPropertyChanged("DozvoljenoPusenje");
                }
            }
        }

        public Cena KategorijaCena
        {
            get { return _kategorijaCena; }
            set
            {
                if (value != _kategorijaCena)
                {
                    _kategorijaCena = value;
                    OnPropertyChanged("KategorijaCena");
                }
            }
        }

        public Alkohol SluzenjeAlkohola
        {
            get { return _sluzenjeAlkohola; }
            set
            {
                if (value != _sluzenjeAlkohola)
                {
                    _sluzenjeAlkohola = value;
                    OnPropertyChanged("SluzenjeAlkohola");
                }
            }
        }

        public int Kapacitet
        {
            get { return _kapacitet; }
            set
            {
                if (value != _kapacitet)
                {
                    _kapacitet = value;
                    OnPropertyChanged("Kapacitet");
                }
            }
        }

        public DateTime DatumOtvaranja
        {
            get { return _datumOtvaranja; }
            set
            {
                if (value != _datumOtvaranja)
                {
                    _datumOtvaranja = value;
                    OnPropertyChanged("DatumOtvaranja");
                }
            }
        }

        public bool Rezervacije
        {
            get { return _rezervacije; }
            set
            {
                if (value != _rezervacije)
                {
                    _rezervacije = value;
                    OnPropertyChanged("Rezervacije");
                }
            }
        }

        
    }
}
