using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Race.DAL.Interface;
using Race.Factory;

namespace Race.LOGIC
{
    public static class TeamCollection
    {
        public static ITeamCollectionRepository TeamCollectionDAL = RaceFactory.CreateTeamCollectionDAL();
        public static void Add(TeamStruct teamStruct)
        {
            TeamCollectionDAL.Add(teamStruct);
        }

        public static void Remove(int id)
        {
            TeamCollectionDAL.Remove(id);
        }

        public static List<Team> GetAll()
        {
            List<Team> TeamList = new List<Team>();
            foreach (TeamStruct teamStruct in TeamCollectionDAL.GetAll())
            {
               TeamList.Add(new Team(teamStruct));
            }

            return TeamList;
        }
    }
}
