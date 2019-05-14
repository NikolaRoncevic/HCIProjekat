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
    /// Interaction logic for IzmenaBrisanjeTipaLokala.xaml
    /// </summary>
    public partial class IzmenaBrisanjeTipaLokala : Window, INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string ikonica;
        public string text;

        private void choseIcon(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    ikonica = ofd.FileName;

                }
                catch (SecurityException ex)
                {
                    System.Windows.MessageBox.Show("Ne moze");
                }
            }

        }

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        public IzmenaBrisanjeTipaLokala()
        {
            InitializeComponent();
            foreach (TipLokala tl in MainWindow.TipoviLokala.Values)
                cbId.Items.Add(tl.Id);
            this.DataContext = this;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            text = (sender as ComboBox).SelectedItem as string;
            TipLokala tip = MainWindow.TipoviLokala[text];
            tbNaziv.Text = tip.Ime;
            tbOpis.Text = tip.Opis;
            ikonica = tip.Ikonica;
        }

        private void Obrisi(object sender, RoutedEventArgs e)
        {
            MainWindow.TipoviLokala.Remove(cbId.Text);
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\Korisnik\Desktop\Lokali.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, MainWindow.Lokali);

            stream.Close();
            this.Close();
        }

        private void saveTip(object sender, RoutedEventArgs e)
        {
            MainWindow.TipoviLokala[text].Ime = tbNaziv.Text;
            MainWindow.TipoviLokala[text].Opis = tbOpis.Text;
            MainWindow.TipoviLokala[text].Ikonica = ikonica;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\Korisnik\Desktop\Lokali.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, MainWindow.Lokali);
            stream.Close();
            this.Close();

        }
    }
}
