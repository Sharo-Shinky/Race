using System.Collections.Generic;

namespace Race.DAL.Interface
{
    public interface ISeasonCollectionDAL
    {
        void Add(SeasonStruct seasonStruct);
        void remove(int Id);
        List<SeasonStruct> GetAll();
    }
}