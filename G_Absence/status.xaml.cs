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
    /// Interaction logic for status.xaml
    /// </summary>
    public partial class status : Page
    {


        double Absence = 0;
        double absenceJu = 0;
        User user;

        public status( string id  )
        {

            InitializeComponent();
            user = (User)Application.Current.Resources["user"];


            var aprenant = user.GetUserById(int.Parse(id));


            aprenant.ForEach(apprenant =>
            {
                Nom.Text = apprenant["firstname"];
                Prenom.Text = apprenant["lastname"];
                

            });




            var absanceList = user.GetAbsencej(id ,"2"  );

            absanceList.ForEach(absence =>
            {




                if (absence["duration"] == "jour" && absence["is_justify"] == "True")
                {
                    absenceJu += 1;
                }else if (absence["duration"] == "jour" && absence["is_justify"] == "False"){


                    Absence += 1;

                }
                else if (absence["duration"] == "demijour" && absence["is_justify"] == "True")
                {

                    absenceJu += 0.5 ;

                }
                else if (absence["duration"] == "demijour" && absence["is_justify"] == "False")
                {

                    Absence += 0.5;

                }


            });



    
            

            AbsJus.Text = Absence.ToString();
            Abs.Text = absenceJu.ToString();
            totalA.Text = (absenceJu + Absence).ToString();





            
        }
    }
}
