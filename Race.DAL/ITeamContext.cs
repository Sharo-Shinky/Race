using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Race.DAL.Interface;

namespace Race.DAL
{
    public interface ITeamContext
    {
        void Add(TeamStruct teamStruct);
        void Remove(int id);
        List<TeamStruct> GetAll();
        void Update(TeamStruct teamStruct);
    }
}
