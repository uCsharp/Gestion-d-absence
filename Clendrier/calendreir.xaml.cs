using System;
using System.Collections.Generic;
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
using System.Globalization;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Clendrier
{
    /// <summary>
    /// Logique d'interaction pour calendreir.xaml
    /// </summary>
    public partial class calendreir : Page
    {
        
        public calendreir()
        {
            InitializeComponent();
            abssance.Visibility = Visibility.Visible;

            justifier.Visibility = Visibility.Hidden;

            Demi.Visibility = Visibility.Hidden;

            DateTime date = DateTime.Now ;

            D1.Content = date.ToLongDateString();
            btnMonth.Content = date.Month;

            SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-IIVAD0V;Initial Catalog = G_Absance;Integrated Security=true");

            cnx.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM absence ", cnx);


           
            

        }


       

        public void Button_Click(object sender, RoutedEventArgs e)

        {
           

          
        }

        private void load(object sender, RoutedEventArgs e)
        {



        }

        private void btnMonth_Click()
        {

        }
    }
}
