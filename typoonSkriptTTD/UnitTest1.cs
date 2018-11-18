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
        
        [Theory]
        [InlineData(-5.0, 0, 0)]
        public void Values_Should_Calculate_Divide(double x, double y, double expected)
        {
            var sut = new Calculator();
            var actual = sut.Divide(x, y);

            Assert.Equal(expected, actual);
        }
    }
}
