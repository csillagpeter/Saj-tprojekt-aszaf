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
    /// Interaction logic for sajtablak.xaml
    /// </summary>
    public partial class sajtablak : Page
    {
        public sajtablak(string sajtNeve)
        {
            InitializeComponent();
            
            SajtCimTextBlock.Text = sajtNeve;
            if (sajtNeve == "Gouda")
            {
                SajtLeirasTextBlock.Text = "Ez egy finom holland sajt...";
            }
            else if (sajtNeve == "Trapista")
            {
                SajtLeirasTextBlock.Text = "Ez a legnépszerűbb magyar sajt...";
            }
        }
       
    }
}
