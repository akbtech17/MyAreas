using NUnit.Framework;
using MyAreas;

namespace TestMyAreas
{
    public class Tests
    {
        Areas areas;

        [SetUp]
        public void Setup()
        {
            // like constructor of the test
            areas = new Areas();
        }

        [TearDown]
        public void Close() {
            // like destructor
            // nullifying the data
            areas = null;
        }

        [Test]
        public void CicleTest()
        {
            // [Test] is important
            // return type is pulic generally
            // 1 - Arrange
            
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
            float expectedResult = 10;
            float actualResult = 0;
            // 2 - Act 
            actualResult = areas.Triangle(5,4);
            // 3 - Assert
            Assert.AreEqual(expectedResult, actualResult, "Areas not matching");

        }
    }
}