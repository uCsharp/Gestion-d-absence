using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace G_Absence
{
    class AdoNET
    {

        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private string connectionString;
        private DataTable dtCat;
        private DataTable dtMovie;
        private DataSet ds;


        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public string ConnectionString { get => connectionString; }
        public DataTable DtCat { get => dtCat; set => dtCat = value; }
        public DataTable DtMovie { get => dtMovie; set => dtMovie = value; }
        public DataSet Ds { get => ds; set => ds = value; }

        public AdoNET()
        {
            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=G_Absance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            ds = new DataSet();

        }
    }
}
