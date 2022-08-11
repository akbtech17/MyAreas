using NUnit.Framework;
using MyAreas;

namespace TestMyAreas
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // like constructor of the test
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void CicleTest()
        {
            // [Test] is important
            // return type is pulic generally
            // 1 - Arrange
            Areas areas = new Areas();
            float expectedResult = 75;
            float actualResult = 0;

            // 2 - Act 
            actualResult = areas.Circle(5);
            // 3 - Assert
            Assert.AreEqual(expectedResult, actualResult,5,"Areas not matching");
      
        }

        [Test]
        public void TriangleTest() {
            // 1 - Arrange
            Areas areas = new Areas();
            float expectedResult = 10;
            float actualResult = 0;
            // 2 - Act 
            actualResult = areas.Triangle(5,4);
            // 3 - Assert
            Assert.AreEqual(expectedResult, actualResult, "Areas not matching");

        }
    }
}