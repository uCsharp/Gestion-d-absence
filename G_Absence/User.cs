using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Absence
{
 

        class User
        {
            private int id;
            private string firstname;
            private string lastname;
            private string email;
            private string role;
            private string classe;

            public string Role { get => role; set => role = value; }
            public string Classe { get => classe; set => classe = value; }

        AdoNET Ado;

            public User(string id, string firstname, string lastname, string email, string role, string classe)
            {
                this.id = int.Parse(id);
                this.firstname = firstname;
                this.lastname = lastname;
                this.email = email;
                this.Role = role;
                this.Classe = classe;
                Ado = new AdoNET();
            }

            public static User login(string email, string password)
            {
                User user = null;

                AdoNET Ado = new AdoNET();
                Ado.Connection.Open();
                Ado.Command.CommandText = "select * from users where email = @email and [password] = @password ";
                Ado.Command.Connection = Ado.Connection;
                Ado.Command.Parameters.AddWithValue("@email", email);
                Ado.Command.Parameters.AddWithValue("@password", password);
                Ado.Reader = Ado.Command.ExecuteReader();
                if (Ado.Reader.HasRows)
                {
                    Ado.Reader.Read();
                    user = new User(Ado.Reader["id"].ToString(), Ado.Reader["firstname"].ToString(), Ado.Reader["lastname"].ToString(), Ado.Reader["email"].ToString(), Ado.Reader["role"].ToString(), Ado.Reader["class"].ToString());

                }

                Ado.Connection.Close();


                return user;


            }


            public bool InsertUser(string firstname, string lastname, string email, string role, string classe, string password)
            {
                if (this.role != "admin")
                    return false;

                Ado.Connection.Open();
                Ado.Command.CommandText = "insert into users values ( @email , @password , @firstname , @lastname , @role , @class )";
                Ado.Command.Connection = Ado.Connection;
                Ado.Command.Parameters.Clear();
                Ado.Command.Parameters.AddWithValue("@email", email);
                Ado.Command.Parameters.AddWithValue("@password", password);
                Ado.Command.Parameters.AddWithValue("@firstname", firstname);
                Ado.Command.Parameters.AddWithValue("@lastname", lastname);
                Ado.Command.Parameters.AddWithValue("@role", role);
                Ado.Command.Parameters.AddWithValue("@class", classe);
                int numRow = Ado.Command.ExecuteNonQuery();
                Ado.Connection.Close();

            return numRow == 1;

                



            }

        public bool AddAbsence(string date, string absenteeId , string duration )
        {

            Ado.Connection.Open();
            Ado.Command.CommandText = "insert into absence values ( @date , @absenteeId , @duration , 0 )";
            Ado.Command.Connection = Ado.Connection;
            Ado.Command.Parameters.Clear();
            Ado.Command.Parameters.AddWithValue("@date", date);
            Ado.Command.Parameters.AddWithValue("@absenteeId", absenteeId);
            Ado.Command.Parameters.AddWithValue("@duration", duration);
            int numRow = Ado.Command.ExecuteNonQuery();
            Ado.Connection.Close();

            return numRow == 1;

        }

        public bool EditAbsence(string duration, string id)
        {

            Ado.Connection.Open();
            Ado.Command.CommandText = "update absence set duration = @duration where id = @id ;  ";
            Ado.Command.Connection = Ado.Connection;
            Ado.Command.Parameters.Clear();
            Ado.Command.Parameters.AddWithValue("@duration", duration);
            Ado.Command.Parameters.AddWithValue("@id", id);
            int numRow = Ado.Command.ExecuteNonQuery();
            Ado.Connection.Close();

            return numRow == 1;

        }

        public bool JustifyAbsence(string is_justify , string id)
        {

            Ado.Connection.Open();
            Ado.Command.CommandText = "update absence set is_justify = @is_justify where id = @id ;  ";
            Ado.Command.Connection = Ado.Connection;
            Ado.Command.Parameters.Clear();

            Ado.Command.Parameters.AddWithValue("@id", id);
            Ado.Command.Parameters.AddWithValue("@is_justify", is_justify);
            int numRow = Ado.Command.ExecuteNonQuery();
            Ado.Connection.Close();

            return numRow == 1;

        }






        public List<Dictionary<string, string>> GetAprenant(int classe)
            {

            var aprenants = new List<Dictionary<string, string>>();

            Ado.Connection.Open();
            Ado.Command.CommandText = "select * from users where class = @class";
            Ado.Command.Connection = Ado.Connection;
            Ado.Command.Parameters.Clear();
            Ado.Command.Parameters.AddWithValue("@class", classe);
            Ado.Reader = Ado.Command.ExecuteReader();
            


            if (Ado.Reader.HasRows)
            {
                while (Ado.Reader.Read())
                {
                    var dict = new Dictionary<string, string> { { "id", Ado.Reader["id"].ToString() }, { "firstname", Ado.Reader["firstname"].ToString() }, { "lastname", Ado.Reader["lastname"].ToString() } };

                    aprenants.Add(dict);

                }

            }
            Ado.Connection.Close();

            return aprenants;



        }

        public List<Dictionary<string, string>> GetAbsence(string id)
        {
            var absence = new List<Dictionary<string, string>>();

            Ado.Connection.Open();
            Ado.Command.CommandText = "select * from  absence where user_id = " +id;
            Ado.Command.Connection = Ado.Connection;
            
            Ado.Reader = Ado.Command.ExecuteReader();

            if (Ado.Reader.HasRows)
            {
                while (Ado.Reader.Read())
                {
                    var dict = new Dictionary<string, string> { { "id", Ado.Reader["id"].ToString() }, { "date", Ado.Reader["date"].ToString() }, { "duration", Ado.Reader["duration"].ToString() } , { "is_justify", Ado.Reader["is_justify"].ToString() } };

                    absence.Add(dict);

                }

            }

            Ado.Connection.Close();


            return absence;

        }



    }

    
}
