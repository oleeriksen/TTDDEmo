using System;
using Xunit;
using ProductionCode;

namespace ProductionCodeTest2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            ISimpleCalculator c = new SimpleCalculator();
            c.X = 3; c.Y = 14;
            
            Assert.Equal(3, c.X);
            Assert.Equal(14, c.Y);

        }

        [Fact]
        public void TestAdd()
        {
            //Arrange
            ISimpleCalculator c = new SimpleCalculator();
            c.X = 3; c.Y = 14;

            Assert.Equal(17, c.Add);

        }

        [Fact]
        public void TestSub()
        {
            //Arrange
            ISimpleCalculator c = new SimpleCalculator();
            c.X = 3; c.Y = 14;

            Assert.Equal(-11, c.Sub);

        }

        [Fact]
        public void TestDiv()
        {
            //Arrange
            ISimpleCalculator c = new SimpleCalculator();
            c.X = 3; c.Y = 14;

            Assert.Equal(0, c.Div);
            c.X = 14; c.Y = 3;
            Assert.Equal(5, c.Div);

        }


        [Fact]
        public void TestDivZero()
        {
            //Arrange
            ISimpleCalculator c = new SimpleCalculator();
            c.X = 3; c.Y = 0;

            Assert.Throws<Exception>(() => c.Div);

        }

        [Fact]
        public void TestSwap()
        {
            //Arrange
            ISimpleCalculator c = new SimpleCalculator();
            c.X = 3; c.Y = 14;
            //Act
            c.Swap();
            //Assert
            Assert.True(c.X == 14 && c.Y == 3 );

        }
    }
}
