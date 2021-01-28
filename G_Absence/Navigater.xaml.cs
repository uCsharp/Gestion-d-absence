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

namespace G_Absence
{
    /// <summary>
    /// Interaction logic for Navigater.xaml
    /// </summary>
    public partial class Navigater : Page
    {

        MainWindow mainWindow;

        public Navigater()
        {
            InitializeComponent();
            mainWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;
        }

        private void classe_Click(object sender, RoutedEventArgs e)
        {
            Button button = (sender as Button);

            switch (button.Name)
            {
                case ("cs"):

                    this.NavigationService.Navigate(new AprenantList(1));
                    break;
                case ("jee"):

                    this.NavigationService.Navigate(new AprenantList(2));
                    break;
                case ("fs"):

                    this.NavigationService.Navigate(new AprenantList(3));
                    break;
                case ("classe1"):

                    this.NavigationService.Navigate(new AprenantList(4));
                    break;
                case ("classe2"):

                    this.NavigationService.Navigate(new AprenantList(5));
                    break;
                case ("classe3"):

                    this.NavigationService.Navigate(new AprenantList(6));
                    break;
                case ("classe4"):

                    this.NavigationService.Navigate(new AprenantList(7));
                    break;

                default:
                    break;
            }
            mainWindow.HomeBtn.IsChecked = false;

        }
    }
}
