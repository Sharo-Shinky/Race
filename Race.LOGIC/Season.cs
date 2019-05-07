using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Race.DAL.Interface;
using Race.Factory;

namespace Race.LOGIC
{
    public class Season
    {
        public int Id { get; private set; }
        public int AantalRaces { get; private set; }
        public string Kampioen { get; private set; }
        public int Jaar { get; private set; }

        public ISeasonDAL SeasonDAL { get; private set; } = RaceFactory.CreateSeasonDAL();

        public Season(SeasonStruct seasonStruct)
        {
            Id = seasonStruct.Id;
            AantalRaces = seasonStruct.AantalRaces;
            Kampioen = seasonStruct.Kampioen;
            Jaar = seasonStruct.Jaar;
        }
        
        public void AddKampioen(string kampioen)
        {
            Kampioen = kampioen;
        }

        public void Update()
        {
            SeasonStruct seasonStruct = new SeasonStruct(Id, AantalRaces, Kampioen, Jaar);
            SeasonDAL.Update(seasonStruct);
        }
    }
}
