using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Race.DAL.Interface;

namespace Race.DAL
{
    public class TeamRepository : ITeamRepository, ITeamCollectionRepository
    {
        public ITeamContext TeamContext { get; set; }

        public TeamRepository(ITeamContext teamContext)
        {
            TeamContext = teamContext;
        }

        public void Add(TeamStruct teamStruct)
        {
            TeamContext.Add(teamStruct);
        }

        public List<TeamStruct> GetAll()
        {
            List<TeamStruct> teamStructList = new List<TeamStruct>();
            foreach (TeamStruct teamStruct in TeamContext.GetAll())
            {
                teamStructList.Add(teamStruct);
            }

            return teamStructList;
        }

        public void Remove(int id)
        {
            TeamContext.Remove(id);
        }

        public void Update(TeamStruct teamStruct)
        {
            TeamContext.Update(teamStruct);
        }
    }
}
