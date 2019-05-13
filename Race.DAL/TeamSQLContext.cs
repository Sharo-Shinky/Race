using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Race.DAL.Interface;
using System.Data.SqlClient;

namespace Race.DAL
{
    public class TeamSQLContext : ITeamContext
    {
        DatabaseConnection DbConn = new DatabaseConnection();
        public void Add(TeamStruct teamStruct)
        {
            using (DbConn.connection)
            {
                string query = "INSERT INTO Team(Naam, StandplaatsStad, StandplaatsLand, Hoofdsponsor, Oprichtingsjaar, Directeur)" +
                               "Values (@Naam, @StandplaatsStad, @StandplaatsLand, @Hoofdsponsor, @Oprichtingsjaar, @Directeur)";
                DbConn.connection.Open();
                SqlCommand command = new SqlCommand(query, DbConn.connection);
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
            using (DbConn.connection)
            {
                string query = "SELECT * FROM Team";
                DbConn.connection.Open();
                SqlCommand command = new SqlCommand(query, DbConn.connection);
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
            using (DbConn.connection)
            {
                string query = "DELETE FROM Team WHERE Id = @Id";
                DbConn.connection.Open();
                SqlCommand command = new SqlCommand(query, DbConn.connection);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Id";
                param.Value = id;
                command.Parameters.Add(param);
                command.ExecuteNonQuery();
            }
        }

        public void Update(TeamStruct teamStruct)
        {
            using (DbConn.connection)
            {
                string query = "UPDATE TEAM SET Naam = @Naam, StandplaatsStad = @StandplaatsStad, " +
                               "StandplaatsLand = @StandplaatsLand, Hoofdsponsor = @Hoofdsponsor, " +
                               "Oprichtingsjaar = @Oprichtingsjaar, Directeur = @Directeur WHERE Id = @Id";
                DbConn.connection.Open();
                SqlCommand command = new SqlCommand(query, DbConn.connection);

                command.Parameters.Add(new SqlParameter("@Naam", teamStruct.Naam));
                command.Parameters.Add(new SqlParameter("@StandplaatsStad", teamStruct.StandplaatsStad));
                command.Parameters.Add(new SqlParameter("@StandplaatsLand", teamStruct.StandplaatsLand));
                command.Parameters.Add(new SqlParameter("@Hoofdsponsor",  teamStruct.Hoofdsponsor));
                command.Parameters.Add(new SqlParameter("@Oprichtingsjaar", teamStruct.Oprichtingsjaar));
                command.Parameters.Add(new SqlParameter("@Directeur", teamStruct.Directeur));
                command.Parameters.Add(new SqlParameter("Id", teamStruct.Id));
                
                command.ExecuteNonQuery();
            }
        }
    }
}
