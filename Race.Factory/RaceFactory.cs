using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Race.DAL;
using Race.DAL.Interface;

namespace Race.Factory
{
    public static class RaceFactory
    {
        public static ITeamRepository CreateTeamDAL()
        {
            return new TeamRepository(new TeamSQLContext());
        }

        public static ITeamCollectionRepository CreateTeamCollectionDAL()
        {
            return new TeamRepository(new TeamSQLContext());
        }

        public static ISeasonDAL CreateSeasonDAL()
        {
            return new SeasonDAL();
        }

        public static ISeasonCollectionDAL CreateSeasonCollectionDal()
        {
            return new SeasonDAL();
        }
    }
}
