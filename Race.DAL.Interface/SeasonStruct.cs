namespace Race.DAL.Interface
{
    public struct SeasonStruct
    {
        public int Id { get; private set; }
        public int AantalRaces { get; private set; }
        public string Kampioen { get; private set; }
        public int Jaar { get; private set; }

        public SeasonStruct(int id, int aantalRaces, string kampioen, int jaar)
        {
            Id = id;
            AantalRaces = aantalRaces;
            Kampioen = kampioen;
            Jaar = jaar;
        }
    }
}