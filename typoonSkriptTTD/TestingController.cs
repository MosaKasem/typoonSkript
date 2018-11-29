using System;
using Domain; // use namespace to reference!
using Xunit;
using Moq;
using System.IO;

namespace typoonSkriptTTD
{
    public class TestingController
    {
        public class FakeConsole : IConsole
        {
            private string fakeinput;
            public FakeConsole(string fakeinput)
            {
                this.fakeinput = fakeinput;
            }
            public string ReadLine()
            {
                return this.fakeinput;
            }
        }
        private Mock<IConsole> mock_fakeConsole;
        private Mock<Calculator> mock_c;
        private Mock<CalculatorView> mock_cv;
        private Mock<Input> mock_i;
        public void SetUpMockObjects()
        {
            mock_fakeConsole = new Mock<IConsole>();
            mock_cv = new Mock<CalculatorView>(mock_fakeConsole.Object);
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
            var fakeConsole = new FakeConsole("+");
            var c = new CalculatorView(fakeConsole);
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
            // FRÅGA HUR KAN MAN TESTA NÄR DET FINNS EN REDALINE INUTI GETINPUT?!
            mock_fakeConsole = new Mock<IConsole>();
            mock_fakeConsole.Setup(s => s.ReadLine()).Returns("+");

            var calcView = new CalculatorView(mock_fakeConsole.Object);
            var actual = calcView.GetInput();

            Operation expected = Operation.plus;

            Assert.Equal(expected, actual);

            // var actual = calcView.GetInput("/");

            // Assert.Equal(expected2, actual2);

        }
        [Fact]
        public void Verify_Methods_Were_Run_Upon_UserInput()
        {
            // FRÅGA: hur verify att metoden Add, eller Subtract hra körts?
            // TYP om jag väljer 
                        SetUpMockObjects();
                        var console = new Calculator(mock_cv.Object);
                        // var actual = console.SimpleCalculator
        }
    }
}