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
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Page
    {
        public AddUser()
        {
            InitializeComponent();
        }

        AdoNET Ado = new AdoNET();
        private void Button_Click(object sender, RoutedEventArgs e)
        {



            string role = ((ComboBoxItem)ro.SelectedItem).Content.ToString();
            string classe = ((ComboBoxItem)clas.SelectedItem).Content.ToString();

            Ado.Connection.Open();
            Ado.Command.CommandText = "insert into users values ( @email , @password , @firstname , @lastname , @role , @class )";
            Ado.Command.Connection = Ado.Connection;
            Ado.Command.Parameters.Clear();
            Ado.Command.Parameters.AddWithValue("@email", email.Text);
            Ado.Command.Parameters.AddWithValue("@password", password.Text);
            Ado.Command.Parameters.AddWithValue("@firstname", Prenom.Text);
            Ado.Command.Parameters.AddWithValue("@lastname", Nom.Text);
            Ado.Command.Parameters.AddWithValue("@role", role);
            Ado.Command.Parameters.AddWithValue("@class", classe);
            int numRow = Ado.Command.ExecuteNonQuery();
            Ado.Connection.Close();


            email.Text = "";
            password.Text = "";
            Prenom.Text = "";
            Nom.Text = "";
            ro.Items.Clear();
            clas.Items.Clear();





        }
    }
}
