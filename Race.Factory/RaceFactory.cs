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
        public static ITeamDAL CreateTeamDAL()
        {
            return new TeamDAL();
        }

        public static ITeamCollectionDAL CreateTeamCollectionDAL()
        {
            return new TeamDAL();
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
