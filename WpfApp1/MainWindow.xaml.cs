using System;
using System.Collections.Generic;
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
    }
}
