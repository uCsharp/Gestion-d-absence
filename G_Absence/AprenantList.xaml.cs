using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for AprenantList.xaml
    /// </summary>
    public partial class AprenantList : Page
    {
        DateTime date;
        User user;
        string[] aprenant;
        string selectedDay;
        Button button;
        int ClassId;

        public AprenantList(int classID)
        {
            InitializeComponent();
            user = (User)Application.Current.Resources["user"];
            date = DateTime.Today;
            dateText.Text = date.ToLongDateString();
            ClassId = classID;
            LoadList();
            

        }

        void LoadList()
        {

            var aprenetList = user.GetAprenant(ClassId);

            aprenetList.ForEach(aprenant =>
            {

                Button button = new Button();
                var bc = new BrushConverter();
                button.Content = aprenant["firstname"] + " " + aprenant["lastname"];

                button.Style = FindResource("present") as Style;
                button.FontSize = 18;
                button.FontWeight = FontWeights.SemiBold;
                button.Background = (Brush)bc.ConvertFrom("#F2F5F7");
                button.BorderBrush = (Brush)bc.ConvertFrom("#DDE4EB");
                button.BorderThickness = new Thickness(0,0,0,1);
                button.Name = "aprenant";
                button.Tag = aprenant["id"];
                aprenantStack.Children.Add(button);



                var absanceList = user.GetAbsence(aprenant["id"]);

                //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: lundi

                Button buttonL = new Button();
                string[] apr = { aprenant["id"], aprenant["firstname"], aprenant["lastname"], null, null, null , null };
                buttonL.Style = FindResource("present") as Style;
                absanceList.ForEach(absence =>
                {


                    if (absence["date"] == date.StartOfWeek(DayOfWeek.Monday).ToString())
                    {
                        apr[3] = absence["id"];
                        apr[4] = absence["duration"];
                        apr[5] = absence["is_justify"];
                        apr[6] = absence["justification"];

                        if (absence["duration"] == "jour" && absence["is_justify"] == "True")
                        {
                            buttonL.Style = FindResource("justify") as Style;

                        }
                        else if (absence["duration"] == "demijour" && absence["is_justify"] == "True")
                        {
                            buttonL.Style = FindResource("demiJourJustify") as Style;

                        }
                        else if (absence["duration"] == "demijour")
                        {

                            buttonL.Style = FindResource("demiJour") as Style;

                        }
                        else if (absence["duration"] == "jour" && absence["is_justify"] == "False" && absence["justification"] != string.Empty)
                        {

                            buttonL.Style = FindResource("jourJ") as Style;

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
                string[] apr1 = { aprenant["id"], aprenant["firstname"], aprenant["lastname"], null, null, null , null };
                buttonMar.Style = FindResource("present") as Style;
                absanceList.ForEach(absence =>
                {

                    if (absence["date"] == date.StartOfWeek(DayOfWeek.Tuesday).ToString())
                    {
                        apr1[3] = absence["id"];
                        apr1[4] = absence["duration"];
                        apr1[5] = absence["is_justify"];
                        apr1[6] = absence["justification"];


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
                        else if (absence["duration"] == "jour" && absence["is_justify"] == "False" && absence["justification"] != string.Empty)
                        {

                            buttonMar.Style = FindResource("jourJ") as Style;

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
                string[] apr2 = { aprenant["id"], aprenant["firstname"], aprenant["lastname"], null, null, null , null };
                buttonMer.Style = FindResource("present") as Style;
                absanceList.ForEach(absence =>
                {



                    if (absence["date"] == date.StartOfWeek(DayOfWeek.Wednesday).ToString())
                    {
                        apr2[3] = absence["id"];
                        apr2[4] = absence["duration"];
                        apr2[5] = absence["is_justify"];
                        apr2[6] = absence["justification"];

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
                        else if (absence["duration"] == "jour" && absence["is_justify"] == "False" && absence["justification"] != string.Empty)
                        {

                            buttonMer.Style = FindResource("jourJ") as Style;

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
                string[] apr3 = { aprenant["id"], aprenant["firstname"], aprenant["lastname"], null, null, null , null };
                buttonJ.Style = FindResource("present") as Style;
                absanceList.ForEach(absence =>
                {



                    if (absence["date"] == date.StartOfWeek(DayOfWeek.Thursday).ToString())
                    {
                        apr3[3] = absence["id"];
                        apr3[4] = absence["duration"];
                        apr3[5] = absence["is_justify"];
                        apr3[6] = absence["justification"];

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
                        else if (absence["duration"] == "jour" && absence["is_justify"] == "False" && absence["justification"] != string.Empty)
                        {

                            buttonJ.Style = FindResource("jourJ") as Style;

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
                string[] apr4 = { aprenant["id"], aprenant["firstname"], aprenant["lastname"], null, null, null , null};
                buttonV.Style = FindResource("present") as Style;
                absanceList.ForEach(absence =>
                {
                    if (absence["date"] == date.StartOfWeek(DayOfWeek.Friday).ToString())
                    {
                        apr4[3] = absence["id"];
                        apr4[4] = absence["duration"];
                        apr4[5] = absence["is_justify"];
                        apr4[6] = absence["justification"];

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
                        else if (absence["duration"] == "jour" && absence["is_justify"] == "False" && absence["justification"] != string.Empty)
                        {

                            buttonV.Style = FindResource("jourJ") as Style;

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
            selectedAprenant.Text = "APRENANT : " + aprenant[1] + " " + aprenant[2];
            selectedApSec.Text = "APRENANT : " + aprenant[1] + " " + aprenant[2];
            fileOpener.Visibility = Visibility.Hidden;

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

                if (aprenant[5] == "True")
                {
                    justifyBtn.IsChecked = true;
                }

                if (user.Role == "secretary")

                {

                    if(aprenant[6] != string.Empty)
                    {
                        fileOpener.Visibility = Visibility.Visible;
                        FileInfo fileInfo = new FileInfo(@"..\..\files\" + aprenant[6]);

                        fileName.Text = fileInfo.Name.Split('£')[1];
                        fileSize.Text = String.Format("{0} {1}", (fileInfo.Length / 1.049e+6).ToString("0.0"), "Mb");

                    }

                    popupSec.Visibility = Visibility.Visible;
                }


            }
            if (user.Role == "former")
            {
                popup.Visibility = Visibility.Visible;

            }



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


        private void Appliquer_btn(object sender, RoutedEventArgs e)
        {

            DateTime dateTime;

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
            else if (demiJourBtn.IsChecked == true)
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
            if (date == DateTime.Today.StartOfWeek(DayOfWeek.Monday) || date == DateTime.Today)
                return;
            date = date.AddDays((int)date.DayOfWeek + 6);
            dateText.Text = date.ToLongDateString();
            ClearStack();
            LoadList();
        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {

            System.Diagnostics.Process.Start(@"..\..\files\" + aprenant[6]);

        }
    }
}
