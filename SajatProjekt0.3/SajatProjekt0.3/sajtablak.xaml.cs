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
        public sajtablak(string sajtNeve, string ar)
        {
            InitializeComponent();

            sajtAlatiszov.Text = ar;
            SajtCimTextBlock.Text = sajtNeve;
            if (sajtNeve == "Gouda")
            {
                SajtLeirasTextBlock.Text = "   Jellemzői: Tradicionális holland, általában" +
                    " tehéntejből készülő félkemény sajt.Íze: Fiatalon lágy és krémes, érlelve karakteres, " +
                    "diós árnyalatú.Felhasználása: Szendvicsekbe, sajttálakra, de borok mellé is tökéletes.";
                SajtKepImage.Source = new BitmapImage(new Uri("Image/gouda.png", UriKind.Relative));
                ar = "Ár: 1500 Ft/kg";
            }
            else if (sajtNeve == "Trapista")
            {
                SajtLeirasTextBlock.Text = "   Jellemzői: Magyarország legnépszerűbb, korong alakú, " +
                    "félkemény sajtja.Íze: Enyhén sós, savanykás, jellegzetesen visszafogott " +
                    "és semleges.Felhasználása: Kiváló rántani, reszelve tésztákra vagy melegszendvicsbe.";
                SajtKepImage.Source = new BitmapImage(new Uri("Image/trapista.jpg", UriKind.Relative));
                ar = "Ár: 1200 Ft/kg";
                
            }
            else if(sajtNeve== "Camaber") 
            {
                SajtLeirasTextBlock.Text = "   Jellemzői: Francia eredetű, lágy sajt, " +
                    "nemespenész bevonattal.Íze: Belül krémes, folyós, intenzív, gombás és földes aromájú.Felhasználása:" +
                    " Kiváló rántva, sütve, áfonyalekvárral vagy friss bagettel.";
                SajtKepImage.Source = new BitmapImage(new Uri("Image/Camembert.jpg", UriKind.Relative));
                ar = "Ár: 2500 Ft/kg";
            }
            else if (sajtNeve == "Kecskesajt")
            {
                SajtLeirasTextBlock.Text = "  Jellemzői: Kecsketejből készülő, a fehértől a penészes " +
                    "kérgűig változó sajt.Íze: Nagyon karakteres, pikáns, enyhén fanyar és jellegzetes aromájú.Felhasználása: " +
                    "Salátákhoz, grillezve, mézzel és dióval kombinálva a legjobb.";
                SajtKepImage.Source = new BitmapImage(new Uri("Image/kecske.jpg", UriKind.Relative));
                 ar = "Ár: 3000 Ft/kg";
            }
            else if (sajtNeve == "Lapka")
            {
                SajtLeirasTextBlock.Text = "Jellemzői: Feldolgozott, ömlesztett sajttermék, " +
                    "amely egyesével van csomagolva.Íze: Nagyon enyhe, krémes, tipikusan sós és tejes jellegű.Felhasználása: " +
                    "Rendkívül gyorsan olvad, ezért hamburgerbe és melegszendvicsbe való.";
                SajtKepImage.Source = new BitmapImage(new Uri("Image/lapkasajt.jpg", UriKind.Relative));
                 ar = "Ár: 800 Ft/kg";
            }
        }
       
    }
}
