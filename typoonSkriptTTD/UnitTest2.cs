using System;
using Domain; // use namespace to reference!
using Xunit;
using Moq;
namespace typoonSkriptTTD
{
    public class UnitTest2
    {
        [Fact]
        public void Values_Should_Calculate_Bla()
        {
            var viewMock = new Mock<CalculatorView>();
            var sut = new Calculator(viewMock.Object);
            Boolean act = sut.IsEligable(Operation.Null);
            Boolean expected = true;
            Assert.Equal(expected, act);
        }
    }
}