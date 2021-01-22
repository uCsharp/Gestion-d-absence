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
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace multi_Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        string cnx = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString.ToString();
       
      
        public MainWindow()
        {
            InitializeComponent();

        }

 


        private void BtnLoginClick(object sender, RoutedEventArgs e)
        {

            if (txtUserName.Text.Trim().Equals(string.Empty) || txtPassword.Password.Trim().Equals(String.Empty))
            {

                incorrect.Visibility = Visibility.Visible;
                incorrect.Text = "Empty champ !!";

            }
            else
            {

                incorrect.Visibility = Visibility.Visible;
                incorrect.Text = "Invalid Email or Password !!";
            }
            try
            {
                DataTable dt = new DataTable();
                SqlConnection connection = new SqlConnection(cnx);
                connection.Open();


                string Query = "SELECT * FROM users WHERE Email = '" + txtUserName.Text + "' and password= '" + txtPassword.Password + "'";
                SqlCommand com = new SqlCommand(Query, connection);



                if (connection.State == ConnectionState.Open)
                {
                    SqlDataReader rd = com.ExecuteReader();


                    if(rd.HasRows)
                    {
                        rd.Read();
                      
                        if (rd[5].ToString().Trim() == "admin")
                        {
                            incorrect.Visibility = Visibility.Visible;
                            incorrect.Text = "admin";
                        }
                        if (rd[5].ToString().Trim() == "Formateur")
                        { 
                            incorrect.Visibility = Visibility.Visible;
                            incorrect.Text = "Formateur";
                        }
                        if (rd[5].ToString().Trim() == "Secrétaire")
                        {
                            incorrect.Visibility = Visibility.Visible;
                            incorrect.Text = "Secrétaire";
                        }
                        if (rd[5].ToString().Trim() == "Apprenant")
                        {
                            incorrect.Visibility = Visibility.Visible;
                            incorrect.Text = "Apprenant";
                        }
                 
                    }
             
                }

       
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private void Border_mouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch
            {
                
            }
        }

        private void Btn_ExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
