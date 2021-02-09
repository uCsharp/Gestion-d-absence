using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        User user;

        public MainWindow()
        {
            InitializeComponent();
            user = (User)Application.Current.Resources["user"];
            HomeBtn.IsChecked = true;

            if(user.Role == "admin" )
            {
                frame.NavigationService.Navigate(new Navigater());
                AddBtn.Visibility = Visibility.Visible;
            }
            else if ( user.Role == "secretary")
            {
                frame.NavigationService.Navigate(new Navigater());
            }
            else if(user.Role == "former")
            {
                int classId = int.Parse(user.Classe);
                frame.NavigationService.Navigate(new AprenantList(classId));

            }
            else
            {
                frame.NavigationService.Navigate(new Calendrier());

            }
            
            

            


        }

        private void HomeBtn_Checked(object sender, RoutedEventArgs e)
        {

            if (user.Role == "admin")
            {
                frame.NavigationService.Navigate(new Navigater());
                
            }
            else if (user.Role == "secretary")
            {
                frame.NavigationService.Navigate(new Navigater());
            }
            else if (user.Role == "former")
            {
                int classId = int.Parse(user.Classe);
                frame.NavigationService.Navigate(new AprenantList(classId));

            }
            else
            {
                frame.NavigationService.Navigate(new Calendrier());

            }
            
        }

        private void logout(object sender, MouseButtonEventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void AddBtn_Checked(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new AddUser());
            
            
        }
    }

    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            
            if(dt.DayOfWeek < startOfWeek)
            {
                int daysToAdd = ((int)startOfWeek - (int)dt.DayOfWeek + 7) % 7;
                return dt.AddDays(daysToAdd);
            }
            else
            {
                int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
                return dt.AddDays(-1 * diff).Date;
            }

           
        }

        public static DateTime GetNextWeekday(DateTime start, DayOfWeek day)
        {
            // The (... + 7) % 7 ensures we end up with a value in the range [0, 6]
            int daysToAdd = ((int)day - (int)start.DayOfWeek + 7) % 7;
            return start.AddDays(daysToAdd);
        }


    }
}
