using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Amjad
{
    public partial class MainWindow : Window
    {
        private void img_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = (Image)sender;
            imgFullScale.Source = img.Source;
            popFullScale.PlacementTarget = img;
            popFullScale.Width = 150;
            popFullScale.Height = 150;
            popFullScale.IsOpen = true;
        }
        private void img_MouseLeave(object sender, MouseEventArgs e)
        {
            popFullScale.IsOpen = false;
        }

    }
}
