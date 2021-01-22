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

        DateTime date;

        User user;

        public MainWindow()
        {
            InitializeComponent();

            user = User.login("salaheddib@gmail.com", "12345");

            date = DateTime.Now.StartOfWeek(DayOfWeek.Saturday);

            DateTime mondayOfLastWeek = DateTime.Now.AddDays(-(int)date.DayOfWeek - 6);

            DateTime mondayOLastWeek = mondayOfLastWeek.AddDays(-(int)date.DayOfWeek - 6);

            //MessageBox.Show(mondayOLastWeek.StartOfWeek(DayOfWeek.Thursday).ToShortDateString());


            var aprenetList = user.GetAprenant(1);

            aprenetList.ForEach(aprenant =>
            {
                
                Button button = new Button();

                button.Content = aprenant["firstname"]+ " " + aprenant["lastname"] ;

                button.Style = FindResource("present") as Style;
                button.FontSize = 18;
                button.FontWeight = FontWeights.SemiBold;
                button.Name = "aprenant";
                button.Click += new RoutedEventHandler(Button_Click);
                button.Tag = aprenant["id"];
                aprenantStack.Children.Add(button);


              
                    var absanceList = user.GetAbsence(aprenant["id"]);

                //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: lundi

                    Button buttonL = new Button();

                    buttonL.Style = FindResource("present") as Style;
                    absanceList.ForEach(absence =>
                    {
                        if (absence["date"] == DateTime.Now.StartOfWeek(DayOfWeek.Monday).ToShortDateString())
                        {
                            

                            if (absence["duration"] == "jour" && absence["is_justify"] == "1")
                            {
                                buttonL.Style = FindResource("justify") as Style;
                            }
                            else if (absence["duration"] == "demijour")
                            {

                                buttonL.Style = FindResource("demiJour") as Style;

                            }
                            else
                            {

                                buttonL.Style = FindResource("jour") as Style;

                            }

                        }

                    });


                    buttonL.Name = "lundi";
                    buttonL.Click += new RoutedEventHandler(Button_Click);
                    buttonL.Tag = aprenant["id"];
                    lundiStack.Children.Add(buttonL);


                //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: mardi

                Button buttonMar = new Button();

                buttonMar.Style = FindResource("present") as Style;
                absanceList.ForEach(absence =>
                {


                    if (absence["date"] == DateTime.Now.StartOfWeek(DayOfWeek.Tuesday).ToString())
                    {

                       

                        if (absence["duration"] == "jour" && absence["is_justify"] == "True" )
                        {
                            buttonMar.Style = FindResource("justify") as Style;
                        }
                        else if (absence["duration"] == "demijour")
                        {

                            buttonMar.Style = FindResource("demiJour") as Style;

                        }
                        else
                        {

                            buttonMar.Style = FindResource("jour") as Style;

                        }

                    }

                });


                buttonMar.Name = "mardi";
                buttonMar.Click += new RoutedEventHandler(Button_Click);
                buttonMar.Tag = aprenant["id"];
                mardiStack.Children.Add(buttonMar);




                //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: mercredi

                Button buttonMer = new Button();

                buttonMer.Style = FindResource("present") as Style;
                absanceList.ForEach(absence =>
                {



                    if (absence["date"] == DateTime.Now.StartOfWeek(DayOfWeek.Wednesday).ToString())
                    {
                       

                        if (absence["duration"] == "jour" && absence["is_justify"] == "1")
                        {
                            buttonMer.Style = FindResource("justify") as Style;
                        }
                        else if (absence["duration"] == "demijour")
                        {

                            buttonMer.Style = FindResource("demiJour") as Style;

                        }
                        else
                        {

                            buttonMer.Style = FindResource("jour") as Style;

                        }

                    }

                });


                buttonMer.Name = "mercredi";
                buttonMer.Click += new RoutedEventHandler(Button_Click);
                buttonMer.Tag = aprenant["id"];
                mercrediStack.Children.Add(buttonMer);


                //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: jeudi

                Button buttonJ = new Button();

                buttonJ.Style = FindResource("present") as Style;
                absanceList.ForEach(absence =>
                {



                    if (absence["date"] == DateTime.Now.StartOfWeek(DayOfWeek.Thursday).ToString())
                    {


                        if (absence["duration"] == "jour" && absence["is_justify"] == "1")
                        {
                            buttonJ.Style = FindResource("justify") as Style;
                        }
                        else if (absence["duration"] == "demijour")
                        {

                            buttonJ.Style = FindResource("demiJour") as Style;

                        }
                        else
                        {

                            buttonJ.Style = FindResource("jour") as Style;

                        }

                    }

                });


                buttonJ.Name = "mercredi";
                buttonJ.Click += new RoutedEventHandler(Button_Click);
                buttonJ.Tag = aprenant["id"];
                jeudiStack.Children.Add(buttonJ);


                //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: vendredi


                Button buttonV = new Button();

                buttonV.Style = FindResource("present") as Style;
                absanceList.ForEach(absence =>
                {



                    if (absence["date"] == DateTime.Now.StartOfWeek(DayOfWeek.Friday).ToString())
                    {


                        if (absence["duration"] == "jour" && absence["is_justify"] == "1")
                        {
                            buttonV.Style = FindResource("justify") as Style;
                        }
                        else if (absence["duration"] == "demijour")
                        {

                            buttonV.Style = FindResource("demiJour") as Style;

                        }
                        else
                        {

                            buttonV.Style = FindResource("jour") as Style;

                        }

                    }

                });


                buttonV.Name = "mercredi";
                buttonV.Click += new RoutedEventHandler(Button_Click);
                buttonV.Tag = aprenant["id"];
                VendrediStack.Children.Add(buttonV);





            });



        }

        private void Button_Click(object sender, RoutedEventArgs e )
        {
            MessageBox.Show(date.StartOfWeek(DayOfWeek.Monday).ToLongDateString());


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
