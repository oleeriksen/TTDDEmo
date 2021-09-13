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
    }
}
