using NUnit.Framework;

namespace Oware.Tests
{
    public class mock : IScoreHouse
    {
       // public List<Seed> seedsInHouse;
         public string name;
         public IScoreHouse scoreHouse; // player's scorehouse
        public mock(string name,IScoreHouse scoreHouse)
        {
            this.name = name;
            this.scoreHouse = scoreHouse;
           // seedsInHouse = new List<Seed>();
        }

        public void AddSeed(Seed seed)
        {
            throw new System.Exception();
        }
        public int GetCount()
        {
            return 4;
        }
        public void Reset()
        {
            throw new System.Exception();
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            House h1 = new House(1,1); 
            //Act 
            h1.ResetHouse();
            //Assert
           Assert.AreEqual(4, h1.GetCount(), "House should have 4 seeds");
        }
        [Test]
        public void Test2()
        {
            //I have commented this section out because i am not sure if it works. I have implemented the interface. 
           //Arrange
            //ScoreHouse name1 = new IScoreHouse();
            //mock mymock = new mock("Annah", 0);
           // Player mymock2 = new mock("Emma", name1);
            
           //Act 
           // mymock2.AddSeedToScoreHouse(4);
            //Assert
            // Assert.AreEqual(4, mymock2.GetCount(), "House should have 4 seeds");


        }
    }
}