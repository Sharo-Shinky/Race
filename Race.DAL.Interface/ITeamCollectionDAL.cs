using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.DAL.Interface
{
    public interface ITeamCollectionDAL
    {
        void Add(TeamStruct teamStruct);
        void Remove(int id);
        List<TeamStruct> GetAll();

    }
}
