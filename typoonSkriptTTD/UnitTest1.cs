using System;
using Domain; // use namespace to reference!
using Xunit;
using Moq;

namespace typoonSkriptTTD
{

    public class UnitTest1
    {
        // [Fact]
        // public void ValueShouldAdd4And5() => Values_Should_Calculate_Add(4.0, 5.0, 9.0);

        [Theory]
        [InlineData(5.5, 5.5, 11.0)]
        [InlineData(25.0, 25.0, 50.0)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Values_Should_Calculate_Add(double x, double y, double expected)
        {
            var mochObj = new Mock<Calculator>();
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
        [Theory]
        [InlineData(50, 2, 100)]
        [InlineData(50, 4, 200)]
        public void Values_Should_Calculate_Multiply(double x, double y, double expected)
        {
            var sut = new Calculator();
            var actual = sut.Multiply(x, y);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(5, 5, 3125)]
        [InlineData(5, 5, 9765625)]
        public void Value_Should_Calculate_Elevated(double x, double y, double expected)
        {
            var sut = new Calculator();
            var actual = sut.Elevate(x, y);

            Assert.Equal(expected, actual);
        }
    }
}
