using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.DAL.Interface
{
    public struct TeamStruct
    {
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public string StandplaatsStad { get; private set; }
        public string StandplaatsLand { get; private set; }
        public string Hoofdsponsor { get; private set; }
        public int Oprichtingsjaar { get; private set; }
        public string Directeur { get; private set; }
        
        public TeamStruct(int id, string naam, string standplaatsStad, string standplaatsLand, string hoofdsponsor, int oprichtingsjaar, string directeur)
        {
            Id = id;
            Naam = naam;
            StandplaatsStad = standplaatsStad;
            StandplaatsLand = standplaatsLand;
            Hoofdsponsor = hoofdsponsor;
            Oprichtingsjaar = oprichtingsjaar;
            Directeur = directeur;
        }
    }
}
