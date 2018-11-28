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
        public void Test_Correct_Type_Of_Calculator()
        {
            var c = new CalculatorView();
            var p = new Calculator(c);

            Assert.IsType<Calculator>(p);
        }
        [Fact]
        public void Test_Correct_Type_Of_App()
        {
            SetUpMockObjects();
            var app = new App(mock_c.Object, mock_cv.Object, mock_i.Object);
            Assert.IsType<App>(app);
        }
        [Fact]
        public void Return_Correct_Operation_Based_On_Argument()
        {
            var calcView = new CalculatorView();
            Operation expected = Operation.divide;
            Operation expected1 = Operation.multiply;
            Operation expected2 = Operation.plus;
            Operation expected3 = Operation.minus;
            var actual = calcView.GetInput("/");
            var actual1 = calcView.GetInput("*");
            var actual2 = calcView.GetInput("+");
            var actual3 = calcView.GetInput("-");
            Assert.Equal(expected, actual);
            Assert.Equal(expected3, actual3);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected1, actual1);
        }
        [Fact]
        public void Input_Should_Return_Correct_Operator()
        {
            /*             SetUpMockObjects();
                        var console = new CalculatorView();
                        var actual = console.ReturnValue("abc");
                        Assert.Equal() */

        }
        /*         [Fact]
                public void TestName()
                {
                    var sut = new CalculatorView();
                    var actual = 
                } */
    }
}