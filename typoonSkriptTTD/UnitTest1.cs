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
        public void testCalculatorAdd()
        {

            double expected = 5;
            var sut = new Calculator();
            double actual = sut.Add(2,5);
            
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void testCalculatorSubtract()
        {

            double expected = 5;
            var sut = new Calculator();
            double actual = sut.Subtract(10,5);
            
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void testCalculatorMultiply()
        {

            double expected = 20;
            var sut = new Calculator();
            double actual = sut.Multiply(10,2);
            
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void testCalculatorDivide()
        {

            double expected = 5;
            var sut = new Calculator();
            double actual = sut.Divide(2,5);
            
            Assert.Equal(expected, actual);
        }
    }
}
