using NUnit.Framework;

namespace Oware.Tests
{
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
           //Arrange

           //Act 

            //Assert
        }
    }
}