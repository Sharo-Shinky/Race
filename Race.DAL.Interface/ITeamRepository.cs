using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.DAL.Interface
{
    public interface ITeamRepository
    {
        void Update(TeamStruct teamStruct);
    }
}
