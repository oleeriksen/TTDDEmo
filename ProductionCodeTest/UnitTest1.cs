using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductionCode;

namespace ProductionCodeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetterAndSetter()
        {
            //Arrange
            ISimpleCalculator c = new SimpleCalculator();
            c.X = 3; c.Y = 14;
            Assert.AreEqual(3, c.X);
            Assert.AreEqual(14, c.Y);

        }

        [DataRow(1, 2, 3)]
        [DataRow(1, -3, -2)]
        [DataTestMethod]
        public void TestAddGenerel(int x, int y, int res) {
            //Arrange
            ISimpleCalculator c = new SimpleCalculator();
            c.X = x; c.Y = y;

            //Act
            int actualRes = c.Add;

            //Assert
            Assert.AreEqual(res, actualRes);
        }
    }
}
