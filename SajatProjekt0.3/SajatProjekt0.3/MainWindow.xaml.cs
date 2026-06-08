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
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace SajatProjekt0._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            VasarlokBeolvasasa();
        }

        private void VasarlokBeolvasasa(string szurtSajt = null)
        {
            List<string> megjelenitendoVasarlok = new List<string>();
            string fajlUtvonal = "vasarlok.txt";

            // HA NEM LÉTEZIK, LÉTREHOZZUK AUTOMATIKUSAN A JÓ HELYRE
            if (!File.Exists(fajlUtvonal))
            {
                string[] alapAdatok = {
            "Kovács János;Gouda",
            "Nagy Szabina;Trapista",
            "Kiss Péter;Camembert",
            "Tóth Gábor;Gouda",
            "Szabó Anna;Kecskesajt"
        };
                File.WriteAllLines(fajlUtvonal, alapAdatok);
            }

            // BEOLVASÁS
            string[] sorok = File.ReadAllLines(fajlUtvonal);

            foreach (string sor in sorok)
            {
                if (string.IsNullOrWhiteSpace(sor)) continue;

                string[] darabok = sor.Split(';');

                if (darabok.Length == 2)
                {
                    string vasarloNeve = darabok[0].Trim();
                    string vasaroltSajt = darabok[1].Trim();

                    // HA NINCS szűrés, vagy a sajt egyezik a kattintott sajttal
                    if (szurtSajt == null || vasaroltSajt.Equals(szurtSajt, StringComparison.OrdinalIgnoreCase))
                    {
                        megjelenitendoVasarlok.Add($"{vasarloNeve} ({vasaroltSajt})");
                    }
                }
            }

            // Ha a szűrés után üres maradt a lista
            if (megjelenitendoVasarlok.Count == 0)
            {
                megjelenitendoVasarlok.Add($"Ehhez a sajthoz nincs vásárló.");
            }

            // ListBox frissítése
            VasarloLista.ItemsSource = megjelenitendoVasarlok;
        }
            

        private void diakMenu_Selected(object sender, RoutedEventArgs e)
        {
            



        }

        private void TrapistaMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TartalomKeret.Navigate(new sajtablak("Trapista" , "Ár: 1200 Ft/kg"));
        }

        private void CamamberMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TartalomKeret.Navigate(new sajtablak("Camaber", "Ár: 2500 Ft/kg"));
        }

        private void goudaMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TartalomKeret.Navigate(new sajtablak("Gouda", "Ár: 1500 Ft / kg"));
        }

        private void LapkaMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TartalomKeret.Navigate(new sajtablak("Lapka", "Ár: 800 Ft/kg"));
        }

        private void kilepesMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void KecskeSajtMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TartalomKeret.Navigate(new sajtablak("Kecskesajt", "Ár: 3000 Ft/kg"));
        }
    }
}
