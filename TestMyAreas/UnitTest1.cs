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

        [TestCase(30, 20, ExpectedResult = 600)]
        [TestCase(40, 10, ExpectedResult = 300)]
        [TestCase(25, 25, ExpectedResult = 630)]
        [TestCase(90, 90, ExpectedResult = 8100)]
        public int RectangleTest(int l, int b) {
            int actualResult = areas.Rectangle(l, b);
            return actualResult;
        }

        [Test]
        public void Login_Null_Message() {
            string expectedResult = "user or pwd is null";
            string acutalResult = areas.Login("Admin","admin");
            Assert.AreEqual(expectedResult, acutalResult, "Messages are not passing");
        }
    }
}