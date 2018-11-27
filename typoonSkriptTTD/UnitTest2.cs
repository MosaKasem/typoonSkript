using System;
using Domain; // use namespace to reference!
using Xunit;
using Moq;
namespace typoonSkriptTTD
{
    public class UnitTest2
    {
        [Fact]
        public void Values_Should_Return_True_On_Correct_Operator()
        {
            var viewMock = new Mock<CalculatorView>();
            var sut = new Calculator(viewMock.Object);
            Assert.Throws<ArgumentException>(() => sut.IsEligable(Operation.Null));
        }

    }
}