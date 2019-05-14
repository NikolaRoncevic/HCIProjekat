using System;
using System.Collections.Generic;
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
    /// Interaction logic for IzmenaIBrsanjeLokala.xaml
    /// </summary>
    public partial class IzmenaIBrsanjeLokala : Window
    {
        public string ikonica;
        public string text;
        public IzmenaIBrsanjeLokala()
        {
            InitializeComponent();
            InitializeComponent();
            foreach (Lokal l in MainWindow.Lokali.Values)
                cbId.Items.Add(l.Id);

            foreach (TipLokala l in MainWindow.TipoviLokala.Values)
                cbTipLokala.Items.Add(l.Id);

            foreach (Etiketa l in MainWindow.Etikete.Values)
                cbEtiketa.Items.Add(l.Id);
        }

        private void CbId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            text = (sender as ComboBox).SelectedItem as string;
            Lokal l = MainWindow.Lokali[text];
            tbNaziv.Text = l.Ime;
            tbOpis.Text = l.Opis;
            cbTipLokala.Text = l.LokalaTip.Id;
            cbSluzenjealkohola.Text = l.SluzenjeAlkohola;
            ikonica = l.Ikonica;
            chbDostupanZaHendikepe.IsChecked = l.DostupnoZaHendikepe;
            chbDozvoljenoPusenje.IsChecked = l.DozvoljenoPusenje;
            ChbRezervacije.IsChecked = l.Rezervacije;
            cbKategorijaCena.Text = l.KategorijaCena;
            tbKapacitet.Text = l.Kapacitet.ToString();
            dpDatumOtvaranja.DisplayDate = l.DatumOtvaranja;
            cbEtiketa.Text = l.Etiketa.Id;

        }

        private void dodajIkonicu(object sender, RoutedEventArgs e)
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
                    System.Windows.MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void ObrisiLokal(object sender, RoutedEventArgs e)
        {
            MainWindow.Lokali.Remove(cbId.Text);
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\Korisnik\Desktop\Lokali.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, MainWindow.Lokali);

            stream.Close();
            this.Close();
        }

        private void IzmeniLokal(object sender, RoutedEventArgs e)
        {
            string ime = tbNaziv.Text;
            string opis = tbOpis.Text;
            bool dostupnoZaHendikepe = (bool)chbDostupanZaHendikepe.IsChecked;
            bool dozvoljenoPusenje = (bool)chbDozvoljenoPusenje.IsChecked;
            string kategorijaCene = cbKategorijaCena.Text;
            string sluzenjeAlkohola = cbSluzenjealkohola.Text;
            int kapacitet = Int32.Parse(tbKapacitet.Text);
            DateTime datumOtvaranja = dpDatumOtvaranja.DisplayDate;
            bool rezervacije = (bool)ChbRezervacije.IsChecked;
            Etiketa etiketa = MainWindow.Etikete[cbEtiketa.Text];
            TipLokala lokalTip = MainWindow.TipoviLokala[cbTipLokala.Text];
            Lokal lokal = new Lokal(text, ime, opis, dostupnoZaHendikepe, dozvoljenoPusenje, kategorijaCene, sluzenjeAlkohola, kapacitet, datumOtvaranja, rezervacije, etiketa, lokalTip, ikonica);
            MainWindow.Lokali[text] = lokal;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\Korisnik\Desktop\Lokali.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, MainWindow.Lokali);

            stream.Close();
            this.Close();
        }
    }
}
