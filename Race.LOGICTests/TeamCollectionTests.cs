using Microsoft.VisualStudio.TestTools.UnitTesting;
using Race.LOGIC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Race.DAL.Interface;


namespace Race.LOGIC.Tests
{
    [TestClass()]
    public class TeamCollectionTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //arrange
            TeamStruct teamStruct = new TeamStruct(0, "Ali", "Breda", "Nederland", "Apple", 2000, "Sharo");
            TeamCollection.Add(teamStruct);

            Team testTeam = new Team(teamStruct);

            //act
            TeamCollection.Add(teamStruct);

            List<Team> team = TeamCollection.GetAll();

            team.Reverse();

            Team lastAdded = team[0];

            //assert
            Assert.AreEqual(testTeam.Naam, lastAdded.Naam);
            Assert.AreEqual(testTeam.StandplaatsStad, lastAdded.StandplaatsStad);
            Assert.AreEqual(testTeam.StandplaatsLand, lastAdded.StandplaatsLand);
            Assert.AreEqual(testTeam.Hoofdsponsor, lastAdded.Hoofdsponsor);
            Assert.AreEqual(testTeam.Oprichtingsjaar, lastAdded.Oprichtingsjaar);
            Assert.AreEqual(testTeam.Directeur, lastAdded.Directeur);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            TeamStruct teamStruct = new TeamStruct(2, "Thomas", "Tilburg", "Nederland", "PSV", 2018, "Yeah");
            Team team = new Team(teamStruct);
            
            team.Update(teamStruct);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            TeamCollection.Remove(4);
        }
    }
}