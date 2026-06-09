using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DVDbolt.UserControls;
using System.Windows;
using System.Windows.Input;

namespace DVDbolt
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

        private void customerMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            feladatPanel.Children.Clear();
            feladatPanel.Children.Add(new UserControls.UserControlCustomer());
        }

        private void userMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            feladatPanel.Children.Clear();
            feladatPanel.Children.Add(new UserControls.UserControlUser());
        }

        private void productMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            feladatPanel.Children.Clear();
            feladatPanel.Children.Add(new UserControls.UserControlProduct());
        }

        private void kilepesMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}