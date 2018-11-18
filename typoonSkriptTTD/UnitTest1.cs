using System;
using Domain; // use namespace to reference!
using Xunit;
using Moq;

namespace typoonSkriptTTD
{
    public class UnitTest1
    {

/*         [Theory]
        [InlineData]
        [Fact] */
/*         [Fact]
        public void tryMock()
        {
            var dataSource = new Mock<()>();
        } */
        [Fact]
        public void CalculatorAdd()
        {

            double expected = 5;
            var sut = new Calculator();
            double actual = sut.Add(2, 3);
            
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CalculatorSubtract()
        {

            double expected = 5;
            var sut = new Calculator();
            double actual = sut.Subtract(10, 5);
            
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CalculatorMultiply()
        {

            double expected = 20;
            var sut = new Calculator();
            double actual = sut.Multiply(10, 2);
            
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CalculatorDivide()
        {

            double expected = 2.5;
            var sut = new Calculator();
            double actual = sut.Divide(5.0, 2.0);
            
            Assert.Equal(expected, actual);
        }
    }
}
