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
    /// Interaction logic for IzmenaIBrisanjeEtikete.xaml
    /// </summary>
    public partial class IzmenaIBrisanjeEtikete : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        int a, r, g, b;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        
        public IzmenaIBrisanjeEtikete()
        {
            InitializeComponent();
            this.DataContext = this;
            foreach (Etiketa etiketa in MainWindow.Etikete.Values)
            {
                cbEtiketa.Items.Add(etiketa.Id);
            }

        }

        private void SacuvajIzmene(object sender, RoutedEventArgs e)
        {
            MainWindow.Etikete[cbEtiketa.Text].Opis = tbOpis.Text;
            MainWindow.Etikete[cbEtiketa.Text].A = a;
            MainWindow.Etikete[cbEtiketa.Text].R = r;
            MainWindow.Etikete[cbEtiketa.Text].G = g;
            MainWindow.Etikete[cbEtiketa.Text].B = b;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\Korisnik\Desktop\Lokali.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, MainWindow.Lokali);
            stream.Close();
            this.Close();
        }

       

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = (sender as System.Windows.Controls.ComboBox).SelectedItem as string;
            Etiketa etiketa = MainWindow.Etikete[text];
            tbOpis.Text = etiketa.Opis;
            tbColor.Background = new SolidColorBrush(Color.FromArgb((byte)etiketa.A, (byte)etiketa.R, (byte)etiketa.G, (byte)etiketa.B));
            a = etiketa.A;
            b = etiketa.B;
            r = etiketa.R;
            g = etiketa.G;
        }
        private void OdabirBoje(object sender,RoutedEventArgs e)
        {
            ColorDialog dig = new ColorDialog();
            dig.ShowDialog();

            if (dig.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbColor.Background = new SolidColorBrush(Color.FromArgb(dig.Color.A, dig.Color.R, dig.Color.G, dig.Color.B));
                a = dig.Color.A;
                r = dig.Color.R;
                g = dig.Color.G;
                b = dig.Color.B;
            }
        }

        private void Izbrisi(object sender, RoutedEventArgs e)
        {

            MainWindow.Etikete.Remove(cbEtiketa.Text);
            

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\Korisnik\Desktop\Lokali.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, MainWindow.Lokali);
            
            stream.Close();
            this.Close();
        }

        
    }
}
