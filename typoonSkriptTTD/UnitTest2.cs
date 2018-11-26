using System;
using Domain; // use namespace to reference!
using Xunit;
using Moq;
namespace typoonSkriptTTD
{
    public class UnitTest2
    {
        [Theory]
        [InlineData(25, 25, true)]
        public void Values_Should_Calculate_Bla(double x, double y, Boolean expected)
        {
            var mochObj = new Mock<Calculator>();

            // actual
            var sut = new Calculator();
            var expect = Operation.plus;
            var actual = sut.isEligable(x, y, expect);

            // assert
            Assert.True(actual);
        }
    }
}