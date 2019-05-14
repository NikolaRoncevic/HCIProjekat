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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Models;

namespace WpfApp1.Panels
{
    /// <summary>
    /// Interaction logic for EtiketaWindow.xaml
    /// </summary>
    public partial class EtiketaWindow : Window, INotifyPropertyChanged
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
        public int a = 0, r = 0, g = 0, b = 0;
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
        public EtiketaWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void OdaberiBoju(object sender, RoutedEventArgs e)
        {
            ColorDialog dig = new ColorDialog();
            dig.ShowDialog();

            if (dig.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbColor.Background = new SolidColorBrush(Color.FromArgb(dig.Color.A, dig.Color.R, dig.Color.G, dig.Color.B));
                this.a = dig.Color.A;
                this.r = dig.Color.R;
                this.g = dig.Color.G;
                this.b = dig.Color.B;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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


            }
            string id = tbId.Text;
            string opis = tbOpis.Text;
            Etiketa etiketa = new Etiketa(id, opis, a, r, g, b);
            if (!MainWindow.Etikete.ContainsKey(etiketa.Id) && flag == 1)
            {
                MainWindow.Etikete.Add(etiketa.Id, etiketa);
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(@"C:\Users\Korisnik\Desktop\Etikete.txt", FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, MainWindow.Etikete);
                stream.Close();
            }
            else
            {
                // todo: sta raditi ako kljuc vec postoji kada dodajem etiketu ili ako je prazno
            }



        }
    }
}
