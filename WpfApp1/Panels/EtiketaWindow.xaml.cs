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
        public Color color;
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

            if(dig.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbColor.Background = new SolidColorBrush(Color.FromArgb(dig.Color.A, dig.Color.R, dig.Color.G, dig.Color.B));
                color = Color.FromArgb(dig.Color.A, dig.Color.R, dig.Color.G, dig.Color.B);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string id = tbId.Text;
            string opis = tbOpis.Text;
            Color boja = color;
            Etiketa etiketa = new Etiketa(id, opis, color);
            if (!MainWindow.Etikete.ContainsKey(etiketa.Id))
            {
                MainWindow.Etikete.Add(etiketa.Id, etiketa);
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(@"C:\Users\Korisnik\Desktop\Etikete.txt", FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, MainWindow.Etikete);
                stream.Close();
            }
            else
            {
                // todo: sta raditi ako kljuc vec postoji kada dodajem etiketu
            }



        }
    }
}
