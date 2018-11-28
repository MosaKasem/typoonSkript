using System;
using Domain; // use namespace to reference!
using Xunit;
using Moq;
using System.IO;

namespace typoonSkriptTTD
{
    public class TestingController
    {
        private Mock<Calculator> mock_c;
        private Mock<CalculatorView> mock_cv;
        private Mock<Input> mock_i;
        public void SetUpMockObjects()
        {
            mock_cv = new Mock<CalculatorView>();
            mock_c = new Mock<Calculator>(mock_cv.Object);
            mock_i = new Mock<Input>();
        }
        public class ConsoleTestClass
        {
            private readonly string _console;
            public ConsoleTestClass(string console)
            {
                this._console = console;
            }
            public string ReadLine()
            {
                return this._console;
            }
        }
        [Fact]
        public void Test_Correct_Type()
        {
            var c = new CalculatorView();
            var p = new Calculator(c);

            Assert.IsType<Calculator>(p);
        }
        [Fact]
        public void Input_Should_Return_Correct_Operator()
        {
            SetUpMockObjects();
            var console = new CalculatorView();

        }
/*         [Fact]
        public void TestName()
        {
            var sut = new CalculatorView();
            var actual = 
        } */
    }
}