using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Race.DAL;
using Race.DAL.Interface;

namespace Race.LOGICTests
{
    public class MemoryFactory
    {
        public static ITeamRepository CreateTeamMemoryContect()
        {
            return new TeamRepository(new TeamMemoryContext());
        }

        public static ITeamCollectionRepository CreateTeamCollectionMemoryContext()
        {
            return new TeamRepository(new TeamMemoryContext());
        }
    }
}
