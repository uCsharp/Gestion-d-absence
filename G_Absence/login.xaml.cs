using System;
using System.Data.SqlClient;
using System.Windows;

using System.Windows.Input;

namespace G_Absence
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {

      

        public login()
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
                try
                {

                    User user = User.login(txtUserName.Text.Trim(), txtPassword.Password.Trim());

                    if (user != null)
                    {
                        Application.Current.Resources["user"] = user;
                        MainWindow dashboard = new MainWindow();
                        dashboard.Show();
                        this.Close();
                    }
                    else
                    {

                        incorrect.Visibility = Visibility.Visible;
                        incorrect.Text = "Invalid Email or Password !!";

                    }


                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error", ex.Message + Environment.NewLine + ex.StackTrace);
                }

               
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
