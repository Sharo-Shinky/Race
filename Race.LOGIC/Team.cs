using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Race.DAL.Interface;
using Race.Factory;

namespace Race.LOGIC
{
    public class Team
    {
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public string StandplaatsStad { get; private set; }
        public string StandplaatsLand { get; private set; }
        public string Hoofdsponsor { get; private set; }
        public int Oprichtingsjaar { get; private set; }
        public string Directeur { get; private set; }

        private ITeamRepository TeamRepository = RaceFactory.CreateTeamSQLContext();

        public Team(TeamStruct teamStruct)
        {
            Id = teamStruct.Id;
            Naam = teamStruct.Naam;
            StandplaatsStad = teamStruct.StandplaatsStad;
            StandplaatsLand = teamStruct.StandplaatsLand;
            Hoofdsponsor = teamStruct.Hoofdsponsor;
            Oprichtingsjaar = teamStruct.Oprichtingsjaar;
            Directeur = teamStruct.Directeur;
        }
        public void Update(TeamStruct teamStruct)
        {
            //TeamStruct TeamStruct = new TeamStruct(Id, Naam, StandplaatsStad, StandplaatsLand, Hoofdsponsor, Oprichtingsjaar, Directeur);
            TeamRepository.Update(teamStruct);
        }
    }
}
