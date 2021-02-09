using G_Absence.CustomControl;
using Microsoft.Win32;
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
    /// Interaction logic for Calendrier.xaml
    /// </summary>
    public partial class Calendrier : Page
    {
        DateTime date;
        User user;
        string[] aprenant;
        string selectedDay;
        Button button;
        int userId;
        bool isPopup = false;

        public Calendrier()
        {
            InitializeComponent();
            user = (User)Application.Current.Resources["user"];
            date = DateTime.Today;
            dateText.Text = date.ToLongDateString();
            userId = user.Id;
            LoadList();

            

        }



        void LoadList()
        {

            var aprenet = user.GetUserById(userId);

            aprenet.ForEach(aprenant =>
            {

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
                aprenantStack.Children.Add(button);



                var absanceList = user.GetAbsence(aprenant["id"]);

                //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: lundi

                Button buttonL = new Button();
                string[] apr = { aprenant["id"], aprenant["firstname"], aprenant["lastname"], null, null, null  , null };
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

                        }else if(absence["duration"] == "jour" && absence["is_justify"] == "False" && absence["justification"] != string.Empty)
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
                string[] apr4 = { aprenant["id"], aprenant["firstname"], aprenant["lastname"], null, null, null , null };
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


            if (aprenant[3] != null)
            {
                uploadControls.Visibility = Visibility.Visible;
                uploadFile.Visibility = Visibility.Hidden;

                if (aprenant[6] != string.Empty)
                {
                    FileInfo fileInfo = new FileInfo(@"..\..\files\" + aprenant[6]);
                    UploadingFileList.Items.Clear();
                    
                    UploadingFileList.Items.Add(new FileDetails()
                    {
                        FileName = fileInfo.Name,
                        FileSize = String.Format("{0} {1}", (fileInfo.Length / 1.049e+6).ToString("0.0"), "Mb"),
                        UploadProgress = 100
                    });

                    uploadControls.Visibility = Visibility.Hidden;
                    uploadFile.Visibility = Visibility.Visible;

                }

                    popup.Visibility = Visibility.Visible;
                    


            }



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



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog() ;
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png|Pdf files (*.pdf)|*.pdf";
            bool? response = openFileDialog.ShowDialog();
            if (response == true)
            {
                string[] files = openFileDialog.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    string filename = System.IO.Path.GetFileName(files[i]);
                    FileInfo fileInfo = new FileInfo(files[i]);

                    uploadControls.Visibility = Visibility.Hidden;
                    uploadFile.Visibility = Visibility.Visible;

                    UploadingFileList.Items.Add(new FileDetails()
                    {
                        FileName = filename,
                        FileSize = String.Format("{0} {1}", (fileInfo.Length / 1.049e+6).ToString("0.0"), "Mb"),
                        UploadProgress = 100
                    });

                    filename = DateTime.Now.ToString().Replace("/", "-").Replace(":", "-") + "£" + filename;

                    File.Copy(files[i], @"..\..\files\" + filename );

                    user.Justification(filename, aprenant[3]);
                    ClearStack();
                    LoadList();

                }

            }

        }


        private void File_Drop(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                string fileName = System.IO.Path.GetFileName(files[0]);


                for (int i = 0; i < files.Length; i++)
                {
                    string filename = System.IO.Path.GetFileName(files[i]);
                    FileInfo fileInfo = new FileInfo(files[i]);
                    UploadingFileList.Items.Add(new FileDetails()
                    {
                        FileName = filename,
                        FileSize = String.Format("{0} {1}", (fileInfo.Length / 1.049e+6).ToString("0.0"), "Mb"),
                        UploadProgress = 100
                    });

                }

            }

        }

        private void popupClose(object sender, MouseButtonEventArgs e)
        {

            Grid grid = (sender as Grid);

            if (isPopup == true)
            {
                isPopup = false;
                return;
            }
            
            if(grid.Name == "uploadPopup")
            {
                isPopup = true;
            }else if(isPopup == false)
            {
                popup.Visibility = Visibility.Hidden;

            }

            
        }
    }
}
