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
        string[] aprenant ;
        string selectedDay;
        Button button;
         

        public MainWindow()
        {
            InitializeComponent();

            user = User.login("salaheddib@gmail.com", "12345");

            date = DateTime.Today;

            dateText.Text = date.ToLongDateString();

            LoadList();



        }

         void LoadList()
        {

            var aprenetList = user.GetAprenant(1);

            aprenetList.ForEach(aprenant =>
            {

                Button button = new Button();

                button.Content = aprenant["firstname"] + " " + aprenant["lastname"];

                button.Style = FindResource("present") as Style;
                button.FontSize = 18;
                button.FontWeight = FontWeights.SemiBold;
                button.Name = "aprenant";
                button.Tag = aprenant["id"];
                aprenantStack.Children.Add(button);



                var absanceList = user.GetAbsence(aprenant["id"]);

                //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: lundi

                Button buttonL = new Button();
                string[] apr = { aprenant["id"], aprenant["firstname"], aprenant["lastname"], null, null , null };
                buttonL.Style = FindResource("present") as Style;
                absanceList.ForEach(absence =>
                {


                    if (absence["date"] == date.StartOfWeek(DayOfWeek.Monday).ToString())
                    {
                        apr[3] = absence["id"];
                        apr[4] = absence["duration"];
                        apr[5] = absence["is_justify"];

                        if (absence["duration"] == "jour" && absence["is_justify"] == "True")
                        {
                            buttonL.Style = FindResource("justify") as Style;

                        }else if(absence["duration"] == "demijour" && absence["is_justify"] == "True")
                        {
                            buttonL.Style = FindResource("demiJourJustify") as Style;

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

                buttonL.Tag = apr;
                lundiStack.Children.Add(buttonL);


                //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: mardi

                Button buttonMar = new Button();
                string[] apr1 = { aprenant["id"], aprenant["firstname"], aprenant["lastname"], null, null,null };
                buttonMar.Style = FindResource("present") as Style;
                absanceList.ForEach(absence =>
                {



                    if (absence["date"] == date.StartOfWeek(DayOfWeek.Tuesday).ToString())
                    {
                        apr1[3] = absence["id"];
                        apr1[4] = absence["duration"];
                        apr1[5] = absence["is_justify"];


                        if (absence["duration"] == "jour" && absence["is_justify"] == "True")
                        {
                            buttonMar.Style = FindResource("justify") as Style;
                        }
                        else if (absence["duration"] == "demijour" && absence["is_justify"] == "True")
                        {
                            buttonMar.Style = FindResource("demiJourJustify") as Style;

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
                buttonMar.Tag = apr1;
                mardiStack.Children.Add(buttonMar);




                //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: mercredi

                Button buttonMer = new Button();
                string[] apr2 = { aprenant["id"], aprenant["firstname"], aprenant["lastname"], null, null , null };
                buttonMer.Style = FindResource("present") as Style;
                absanceList.ForEach(absence =>
                {



                    if (absence["date"] == date.StartOfWeek(DayOfWeek.Wednesday).ToString())
                    {
                        apr2[3] = absence["id"];
                        apr2[4] = absence["duration"];
                        apr2[5] = absence["is_justify"];

                        if (absence["duration"] == "jour" && absence["is_justify"] == "True")
                        {
                            buttonMer.Style = FindResource("justify") as Style;
                        }
                        else if (absence["duration"] == "demijour" && absence["is_justify"] == "True")
                        {
                            buttonMer.Style = FindResource("demiJourJustify") as Style;

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

                buttonMer.Tag = apr2;
                mercrediStack.Children.Add(buttonMer);


                //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: jeudi

                Button buttonJ = new Button();
                string[] apr3 = { aprenant["id"], aprenant["firstname"], aprenant["lastname"], null, null , null };
                buttonJ.Style = FindResource("present") as Style;
                absanceList.ForEach(absence =>
                {



                    if (absence["date"] == date.StartOfWeek(DayOfWeek.Thursday).ToString())
                    {
                        apr3[3] = absence["id"];
                        apr3[4] = absence["duration"];
                        apr3[5] = absence["is_justify"];

                        if (absence["duration"] == "jour" && absence["is_justify"] == "True")
                        {
                            buttonJ.Style = FindResource("justify") as Style;
                        }
                        else if (absence["duration"] == "demijour" && absence["is_justify"] == "True")
                        {
                            buttonJ.Style = FindResource("demiJourJustify") as Style;

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


                buttonJ.Name = "jeudi";
                buttonJ.Click += new RoutedEventHandler(Button_Click);

                buttonJ.Tag = apr3;
                jeudiStack.Children.Add(buttonJ);


                //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: vendredi


                Button buttonV = new Button();
                string[] apr4 = { aprenant["id"], aprenant["firstname"], aprenant["lastname"], null, null  , null};
                buttonV.Style = FindResource("present") as Style;
                absanceList.ForEach(absence =>
                {



                    if (absence["date"] == date.StartOfWeek(DayOfWeek.Friday).ToString())
                    {
                        apr4[3] = absence["id"];
                        apr4[4] = absence["duration"];
                        apr4[5] = absence["is_justify"];

                        if (absence["duration"] == "jour" && absence["is_justify"] == "True")
                        {
                            buttonV.Style = FindResource("justify") as Style;
                        }
                        else if (absence["duration"] == "demijour" && absence["is_justify"] == "True")
                        {
                            buttonV.Style = FindResource("demiJourJustify") as Style;

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


                buttonV.Name = "vendredi";
                buttonV.Click += new RoutedEventHandler(Button_Click);

                buttonV.Tag = apr4;
                VendrediStack.Children.Add(buttonV);





            });

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            button = (sender as Button);
            aprenant = button.Tag as string[];
            selectedDay = button.Name;
            selectedAprenant.Text = "APRENANT : " + aprenant[1] + " " + aprenant[2]  ;
            selectedApSec.Text = "APRENANT : " + aprenant[1] + " " + aprenant[2] ;

            if (aprenant[3] != null)
            {
                if (aprenant[4] == "jour")
                {
                    jourBtn.IsChecked = true;
                }
                else
                {
                    demiJourBtn.IsChecked = true;
                }

                if(aprenant[5] == "True")
                {
                    justifyBtn.IsChecked = true;
                }

                popupSec.Visibility = Visibility.Visible;
            }

            //popup.Visibility = Visibility.Visible;


        }



        private void Annuler_btn(object sender, RoutedEventArgs e)
        {
            Clearbtn();

        }




        private void Appliquer_sec_btn(object sender, RoutedEventArgs e)
        {

           


            if (justifyBtn.IsChecked == true)
            {
                user.JustifyAbsence("1", aprenant[3]);
                Clearbtn();
            }
            else 
            {
                user.JustifyAbsence("0", aprenant[3]);
                Clearbtn();

            }

            ClearStack();
            LoadList();


        }


        private void Appliquer_btn(object sender, RoutedEventArgs e   )
        {

            DateTime dateTime ;

            switch (selectedDay)
            {
                case "lundi":
                    dateTime = date.StartOfWeek(DayOfWeek.Monday);
                    break;
                case "mardi":
                    dateTime = date.StartOfWeek(DayOfWeek.Tuesday);
                    break;
                case "mercredi":
                    dateTime = date.StartOfWeek(DayOfWeek.Wednesday);
                    break;
                case "jeudi":
                    dateTime = date.StartOfWeek(DayOfWeek.Thursday);
                    break;

                default:
                    dateTime = date.StartOfWeek(DayOfWeek.Friday);
                    break;
            }

            if (jourBtn.IsChecked == true)
            {
                if (aprenant[3] != null)
                {
                    user.EditAbsence("jour", aprenant[3]);
                    Clearbtn();
                }
                else
                {
                    user.AddAbsence(dateTime.ToString(), aprenant[0], "jour");
                    Clearbtn();


                }

            } 
            else if(demiJourBtn.IsChecked == true)
            {
                if (aprenant[3] != null)
                {
                    user.EditAbsence("demijour", aprenant[3]);
                    Clearbtn();
                }
                else
                {
                    user.AddAbsence(dateTime.ToString(), aprenant[0], "demijour");  
                    Clearbtn();

                }
               

            }

            ClearStack();
            LoadList();


        }




        void Clearbtn()
        {
            popup.Visibility = Visibility.Hidden;
            popupSec.Visibility = Visibility.Hidden;
            jourBtn.IsChecked = false;
            demiJourBtn.IsChecked = false;
            justifyBtn.IsChecked = false;

        }

        void ClearStack()
        {

            aprenantStack.Children.Clear();
            lundiStack.Children.Clear();
            mardiStack.Children.Clear();
            mercrediStack.Children.Clear();
            jeudiStack.Children.Clear();
            VendrediStack.Children.Clear();

        }

        private void Previous_Wekk(object sender, RoutedEventArgs e)
        {
            date = date.AddDays(-(int)date.DayOfWeek - 6);
            dateText.Text = date.ToLongDateString();
            ClearStack();
            LoadList();


        }

        private void Next_Week(object sender, RoutedEventArgs e)
        {
            if (date == DateTime.Today)
                return;
            date = date.AddDays((int)date.DayOfWeek + 6);
            dateText.Text = date.ToLongDateString();
            ClearStack();
            LoadList();
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
