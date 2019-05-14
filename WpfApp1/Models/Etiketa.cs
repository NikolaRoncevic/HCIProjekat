using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp1.Models
{
    [Serializable]
    public class Etiketa : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        private string _id;
        private string _opis;
        private int _a, _r, _g, _b;

        public int A
        {
            get { return _a; }
            set
            {
                if (value != _a)
                {
                    _a = value;
                    OnPropertyChanged("A");
                }
            }
        }
        public int R
        {
            get { return _r; }
            set
            {
                if (value != _r)
                {
                    _r = value;
                    OnPropertyChanged("R");
                }
            }
        }
        public int G
        {
            get { return _g; }
            set
            {
                if (value != _g)
                {
                    _g = value;
                    OnPropertyChanged("G");
                }
            }
        }
        public int B
        {
            get { return _b; }
            set
            {
                if (value != _b)
                {
                    _b = value;
                    OnPropertyChanged("B");
                }
            }
        }


        public Etiketa(string id, string opis, int a, int r, int g, int b)
        {
            Id = id;
            Opis = opis;
            A = a;
            R = r;
            G = g;
            B = b;
        }

        public string Id
        {
            get { return _id; }
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
    }
}
