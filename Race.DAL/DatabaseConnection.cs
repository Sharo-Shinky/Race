using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.DAL
{
    public class DatabaseConnection
    {
        public SqlConnection connection = new SqlConnection(connectionstring);
        const string connectionstring =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\249519\source\repos\Race\Race.DAL\RaceDatabase.mdf;Integrated Security = True";

        //public SqlConnection GetConnection()
        //{
        //    return connection = new SqlConnection(connectionstring);
        //}
    }
}
