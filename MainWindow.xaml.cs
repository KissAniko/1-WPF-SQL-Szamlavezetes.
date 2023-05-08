using System;
using System.Collections.Generic;
using System.IO;
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

namespace Számlavezetés
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Tetel> tetelek = new List<Tetel>();   
        public MainWindow()
        {
            InitializeComponent();
            lbLista.ItemsSource = tetelek;
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            String csvsor = $"{txtID.Text}; {dpDatum}; {txtOsszeg.Text}; {txtPartner.Text}; {txtfoKategoria.Text}; {txtalKategoria.Text}";
            Tetel ujTetel = new Tetel (csvsor) ;
            tetelek.Add(ujTetel) ;
            lbLista.Items.Refresh() ;   // frissítés
        }
       
        private void btnElment_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("tetelek.csv", append : true);
            foreach ( var elem in tetelek)
            {
                String csvsor = $"{elem.Id}; {elem.Datum}; {elem.Osszeg}; {elem.PartnerNeve}; {elem.FoKategoria}; {elem.AlKategoria}"; 
                // a TETEL.cs fájlban get--set.. ezek az 'elemek' ott olvashatók

                sw.WriteLine();
            }
            sw.Close(); 
        }
    }
}
