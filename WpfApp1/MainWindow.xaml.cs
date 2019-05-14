using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        public static Dictionary<string,TipLokala> TipoviLokala = new Dictionary<string, TipLokala>();
        public static Dictionary<string, Lokal> Lokali = new Dictionary<string, Lokal>();
        public static Dictionary<string, Etiketa> Etikete = new Dictionary<string, Etiketa>();

        

        public MainWindow()
        {
            InitializeComponent();
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream(@"C:\Users\Korisnik\Desktop\TipoviLokala.txt", FileMode.OpenOrCreate, FileAccess.Read);
            if (new FileInfo(@"C:\Users\Korisnik\Desktop\TipoviLokala.txt").Length != 0)
            {
                TipoviLokala = (Dictionary<string, TipLokala>)formatter.Deserialize(stream);
            }

            stream = new FileStream(@"C:\Users\Korisnik\Desktop\Etikete.txt", FileMode.OpenOrCreate, FileAccess.Read);
            if (new FileInfo(@"C:\Users\Korisnik\Desktop\Etikete.txt").Length != 0)
            {
                Etikete = (Dictionary<string, Etiketa>)formatter.Deserialize(stream);
            }

            stream = new FileStream(@"C:\Users\Korisnik\Desktop\Lokali.txt", FileMode.OpenOrCreate, FileAccess.Read);
            if (new FileInfo(@"C:\Users\Korisnik\Desktop\Lokali.txt").Length != 0)
            {
                Lokali = (Dictionary<string, Lokal>)formatter.Deserialize(stream);
            }
        }

        private void Dodaj_Lokal(object sender, RoutedEventArgs e)
        {
            var s = new Panels.LokalWindow2();
            s.Show();
        }

        private void Dodaj_Tip(object sender, RoutedEventArgs e)
        {
            var s = new Panels.TipWindow();
            s.Show();
        }

        private void Prikazi_Tabelu(object sender, RoutedEventArgs e)
        {
            var s = new Panels.Tabela();
            s.Show();
        }

        private void Dodaj_Etiketu(object sender, RoutedEventArgs e)
        {
            var s = new Panels.EtiketaWindow();
            s.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = new Panels.IzmenaIBrisanjeEtikete();
            s.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var s = new Panels.IzmenaBrisanjeTipaLokala();
            s.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var s = new Panels.IzmenaIBrsanjeLokala();
            s.Show();
        }
    }
}
