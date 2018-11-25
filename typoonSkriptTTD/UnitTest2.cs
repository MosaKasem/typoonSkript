using System;
using Domain; // use namespace to reference!
using Xunit;
using Moq;
namespace typoonSkriptTTD
{
    public class UnitTest2
    {
        [Theory]
        [InlineData(Operation.divide, Operation.plus)]
        public void Values_Should_Calculate_Bla(Operation actual, Operation expected)
        {
            var mochObj = new Mock<Calculator>();

            // actual
            var sut = new Calculator();
            actual = sut.MyOptions(actual);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}