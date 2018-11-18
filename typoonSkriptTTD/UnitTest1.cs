using System;
using Domain; // use namespace to reference!
using Xunit;
using Moq;

namespace typoonSkriptTTD
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(5.5, 5.5, 11.0)]
        [InlineData(25.0, 25.0, 50.0)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Values_Should_Calculate_Add(double x, double y, double expected)
        {
            // actual
            var sut = new Calculator();
            var actual = sut.Add(x, y);

            // assert
            Assert.Equal(expected, actual);
        }

/*         [Fact]
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
        } */
    }
}
