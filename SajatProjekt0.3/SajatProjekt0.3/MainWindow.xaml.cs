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
        }

        private void diakMenu_Selected(object sender, RoutedEventArgs e)
        {
            



        }

        private void TrapistaMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TartalomKeret.Navigate(new sajtablak("Trapista"));
        }

        private void CamamberMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TartalomKeret.Navigate(new sajtablak("Camaber"));
        }

        private void goudaMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TartalomKeret.Navigate(new sajtablak("Gouda"));
        }

        private void LapkaMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TartalomKeret.Navigate(new sajtablak("Lapka"));
        }

        private void kilepesMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
