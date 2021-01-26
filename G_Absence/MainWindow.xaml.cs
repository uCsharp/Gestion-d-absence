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



        public MainWindow()
        {
            InitializeComponent();


            frame.NavigationService.Navigate(new AprenantList());

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
