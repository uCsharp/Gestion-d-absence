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
    /// Interaction logic for CrudTable.xaml
    /// </summary>
    public partial class CrudTable : Page
    {

        User user;

        List<Dictionary<string, string>> aprenetList;
        string Role;

        public CrudTable()
        {
            InitializeComponent();

            InitializeComponent();
            user = (User)Application.Current.Resources["user"];


            LoadList(Role);


        }


        void LoadList(string Role)
        {

            if (Role != null)
            {
                aprenetList = user.GetRole(Role);
            }
            else
            {
                aprenetList = user.GetAprenant(1);
            }

            aprenetList.ForEach(aprenant =>
            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
                //-------------------------show Nom

                Button button = new Button();
                var bc = new BrushConverter();

                button.Content = aprenant["firstname"] + " " + aprenant["lastname"];

                button.Style = FindResource("present") as Style;
                button.FontSize = 18;
                button.FontWeight = FontWeights.SemiBold;
                button.Background = (Brush)bc.ConvertFrom("#F2F5F7");
                button.BorderBrush = (Brush)bc.ConvertFrom("#DDE4EB");
                button.BorderThickness = new Thickness(0, 0, 0, 1);
                button.Name = "aprenant";
                button.Tag = aprenant["id"];
                Nom.Children.Add(button);





                //------------------------show Email

                Button buttonE = new Button();



                buttonE.Content = aprenant["Email"];

                buttonE.Style = FindResource("present") as Style;
                buttonE.FontSize = 18;
                buttonE.FontWeight = FontWeights.SemiBold;
                buttonE.Background = (Brush)bc.ConvertFrom("#FFFFFF");
                buttonE.BorderBrush = (Brush)bc.ConvertFrom("#DDE4EB");
                buttonE.BorderThickness = new Thickness(0, 0, 0, 1);
                buttonE.Name = "aprenant";
                buttonE.Tag = aprenant["id"];
                Email.Children.Add(buttonE);

                //------------------------------show crud 


                //-------------------------------------- supprimee
                Button buttonS = new Button();


                buttonS.Style = FindResource("crudS") as Style;
                buttonS.FontSize = 15;
                buttonS.FontWeight = FontWeights.Normal;
                buttonS.BorderBrush = (Brush)bc.ConvertFrom("#DDE4EB");
                buttonS.BorderThickness = new Thickness(0, 0, 0, 1);
                buttonS.Content = "Supprimé";
                buttonS.Name = "aprenant";
                buttonS.Tag = aprenant["id"];
                buttonS.Click += new RoutedEventHandler(Suprimer);
                CrudS.Children.Add(buttonS);


                //--------------------------------- modifié
                Button buttonM = new Button();
                buttonM.Style = FindResource("crudM") as Style;
                buttonM.FontSize = 15;
                buttonM.FontWeight = FontWeights.Normal;

                buttonM.BorderBrush = (Brush)bc.ConvertFrom("#DDE4EB");
                buttonM.BorderThickness = new Thickness(0, 0, 0, 1);
                buttonM.Name = "aprenant";
                buttonM.Content = "Modifié";
                buttonM.Click += new RoutedEventHandler(Modifié);

                buttonM.Tag = aprenant["id"];
                CrudM.Children.Add(buttonM);


            });
        }

        private void Suprimer(object sender, RoutedEventArgs e)
        {

            Button button = (sender as Button);
            user.supUsers(button.Tag.ToString());
            ClearStack();
            LoadList(Role);


        }


        private void Modifié(object sender, RoutedEventArgs e)
        {
            Button button = (sender as Button);
            string id = button.Tag.ToString();

            this.NavigationService.Navigate(new AddUser(id));
        }


        void ClearStack()
        {

            Nom.Children.Clear();
            Email.Children.Clear();
            CrudM.Children.Clear();
            CrudS.Children.Clear();

        }



        private void GetAdmin(object sender, RoutedEventArgs e)
        {

            Role = "admin";
            ClearStack();
            LoadList(Role);


        }

        private void Secrétaire(object sender, RoutedEventArgs e)
        {
            Role = "secretary";
            ClearStack();
            LoadList(Role);
        }

        private void Formateur(object sender, RoutedEventArgs e)
        {
            Role = "former";
            ClearStack();
            LoadList(Role);
        }

        private void Apprenant(object sender, RoutedEventArgs e)
        {
            Role = "apprenant";
            ClearStack();
            LoadList(Role);
        }

    }
}
