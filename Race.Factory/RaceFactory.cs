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
        public static ITeamRepository CreateTeamSQLContext()
        {
            return new TeamRepository(new TeamSQLContext());
        }

        public static ITeamCollectionRepository CreateTeamCollectionSQLContext()
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
