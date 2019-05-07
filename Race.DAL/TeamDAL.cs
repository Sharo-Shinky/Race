using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Race.DAL.Interface;
using System.Data.SqlClient;

namespace Race.DAL
{
    public class TeamDAL : ITeamDAL, ITeamCollectionDAL
    {
        private SqlConnection connection;
        const string connectionstring =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\249519\source\repos\Race\Race.DAL\RaceDatabase.mdf;Integrated Security = True";

        private SqlConnection GetConnection()
        {
            return connection = new SqlConnection(connectionstring);
        }
        public void Add(TeamStruct teamStruct)
        {
            using (GetConnection())
            {
                string query = "INSERT INTO Team(Naam, StandplaatsStad, StandplaatsLand, Hoofdsponsor, Oprichtingsjaar, Directeur)" +
                               "Values (@Naam, @StandplaatsStad, @StandplaatsLand, @Hoofdsponsor, @Oprichtingsjaar, @Directeur)";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@Naam", teamStruct.Naam));
                command.Parameters.Add(new SqlParameter("@StandplaatsStad", teamStruct.StandplaatsStad));
                command.Parameters.Add(new SqlParameter("@StandplaatsLand", teamStruct.StandplaatsLand));
                command.Parameters.Add(new SqlParameter("@HoofdSponsor", teamStruct.Hoofdsponsor));
                command.Parameters.Add(new SqlParameter("@Oprichtingsjaar", teamStruct.Oprichtingsjaar));
                command.Parameters.Add(new SqlParameter("@Directeur", teamStruct.Directeur));
                command.ExecuteNonQuery();
            }
        }
        
        public List<TeamStruct> GetAll()
        {
            List<TeamStruct> teamStructList = new List<TeamStruct>();
            using (GetConnection())
            {
                string query = "SELECT * FROM Team";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        teamStructList.Add(new TeamStruct(reader.GetInt32(0), reader.GetString(1),
                                                          reader.GetString(2), reader.GetString(3),
                                                          reader.GetString(4), reader.GetInt32(5),
                                                          reader.GetString(6)));

                    }
                }
            }

            return teamStructList;
        }

        public void Remove(int id)
        {
            using (GetConnection())
            {
                string query = "DELETE FROM Team WHERE Id = @Id";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Id";
                param.Value = id;
                command.Parameters.Add(param);
                command.ExecuteNonQuery();
            }
        }

        public void Update(TeamStruct teamStruct)
        {
            using (connection)
            {
                string query = "UPDATE TEAM SET Naam = @Naam, StandplaatsStad = @StandplaatsStad, " +
                               "StandplaatsLand = @StandplaatsLand, Hoofdsponsor = @Hoofdsponsor, " +
                               "Oprichtingsjaar = @Oprichtingsjaar, Directeur = @Directeur";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Naam", teamStruct.Naam);
                command.Parameters.AddWithValue("@StandplaatsStad", teamStruct.StandplaatsStad);
                command.Parameters.AddWithValue("@StandplaatsLand", teamStruct.StandplaatsLand);
                command.Parameters.AddWithValue("@Hoofdsponsor", teamStruct.Hoofdsponsor);
                command.Parameters.AddWithValue("@Oprichtingsjaar", teamStruct.Oprichtingsjaar);
                command.Parameters.AddWithValue("@Directeur", teamStruct.Oprichtingsjaar);
            }
        }
    }
}
