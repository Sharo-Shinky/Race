using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Race.DAL.Interface;

namespace Race.DAL
{
    public class SeasonDAL : ISeasonCollectionDAL, ISeasonDAL
    {
        private SqlConnection connection;
        const string connectionstring =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\249519\source\repos\Race\Race.DAL\RaceDatabase.mdf;Integrated Security = True";

        private SqlConnection GetConnection()
        {
            return connection = new SqlConnection(connectionstring);
        }   
        public void Add(SeasonStruct seasonStruct)
        {
            using (GetConnection())
            {
                string query = "INSERT INTO Season(AantalRaces, Kampioen, Jaar) Values (@AantalRaces, @Kampioen, @Jaar)";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@AantalRaces", seasonStruct.AantalRaces));
                command.Parameters.Add(new SqlParameter("@Kampioen", seasonStruct.Kampioen));
                command.Parameters.Add(new SqlParameter("@Jaar", seasonStruct.Jaar));
                command.ExecuteNonQuery();
            }
        }

        public List<SeasonStruct> GetAll()
        {
            List<SeasonStruct> seasonStructList = new List<SeasonStruct>();
            using (GetConnection())
            {
                string query = "SELECT * FROM Season";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        seasonStructList.Add(new SeasonStruct(reader.GetInt32(0), reader.GetInt32(1),
                                                              reader.GetString(2), reader.GetInt32(3)));

                    }
                }
            }

            return seasonStructList;
        }

        public void remove(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(SeasonStruct seasonStruct)
        {
            throw new NotImplementedException();
        }
    }
}
