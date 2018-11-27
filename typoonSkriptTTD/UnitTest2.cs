using System;
using Domain; // use namespace to reference!
using Xunit;
using Moq;
namespace typoonSkriptTTD
{
    public class UnitTest2
    {
        [Fact]
        public void Values_Should_Throw_Exception_On_Null_Operation()
        {
            var viewMock = new Mock<CalculatorView>();
            var sut = new Calculator(viewMock.Object);
            Assert.Throws<ArgumentException>(() => sut.IsEligable(Operation.Null));
        }
        [Fact]
        public void Test_App_With()
        {
            // app.Verify(m => m.application(), Times.AtLeastOnce());
            var viewMock = new Mock<CalculatorView>();
            var sut = new Calculator(viewMock.Object);
            viewMock.Verify(s => s.ReturnValue("T"), Times.Once());
        }

    }
}