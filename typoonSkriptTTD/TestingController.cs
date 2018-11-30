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
            public void WriteLine(string msg)
            {
                Console.WriteLine(msg);
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
        /*         public class ConsoleTestClass
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
                } */
        [Fact]
        public void Test_Correct_Type_Of_Calculator()
        {
            var fakeConsole = new FakeConsole("");
            var c = new CalculatorView(fakeConsole);
            var p = new Calculator(fakeConsole, c);

            Assert.IsType<Calculator>(p);
        }
        [Fact]
        public void Test_Correct_Type_Of_App()
        {
            SetUpMockObjects();
            var fakec = new FakeConsole("");
            var inp = new Input();
            var calvV = new CalculatorView(fakec);
            var calc = new Calculator(fakec, calvV);
            // fråga: varför funkar inte det här med mock object?!
            // var app = new App(mock_c.Object, mock_cv.Object, mock_i.Object);
            var app = new App(calc, calvV, inp);
            Assert.IsType<App>(app);
        }
        [Fact]
        public void Test_Correct_Type_Of_CalculatorView()
        {
            SetUpMockObjects();
            var calcview = new CalculatorView(mock_fakeConsole.Object);
            Assert.IsType<CalculatorView>(calcview);
        }
        [Fact]
        public void Return_Correct_Operation_Based_On_Argument()
        {
            mock_fakeConsole = new Mock<IConsole>();
            mock_fakeConsole.Setup(s => s.ReadLine()).Returns("+");
            var calcView = new CalculatorView(mock_fakeConsole.Object);
            var actual = calcView.GetInput();
            Operation expected = Operation.plus;
            Assert.Equal(expected, actual);
        }
/*         [Fact]
        public void Verify_Add_Was_Run_Inside_SimpleCalculator()
        {
            // Fråga: Verify Add was run, funkar ej!
            SetUpMockObjects();
            mock_c.Setup(m => m.Add(It.IsAny<double>(), It.IsAny<double>()));
            mock_c.Setup(m => m.Add(25.0, 25.0));
            var calculator = new Calculator(mock_fakeConsole.Object, mock_cv.Object);
            calculator.SimpleCalculator(25.0, 25.0, Operation.plus);
            mock_c.Verify(m => m.Add(It.IsAny<double>(), It.IsAny<double>()), Times.AtLeastOnce());
        } */
        [Fact]
        public void Verify_Subtract_Was_Run_Inside_SimpleCalculator()
        {
            SetUpMockObjects();
            // mock_c.Setup(a => a.Subtract(It.IsAny<double>(), It.IsAny<double>()));
            // mock_c.Setup(s => s.SimpleCalculator(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<Operation>()));
            var fakeconsole = new FakeConsole("");
            var calcView = new CalculatorView(fakeconsole);
            var calculator = new Calculator(fakeconsole, calcView);
            // var calculator = new Calculator(mock_fakeConsole.Object, mock_cv.Object);
            // calculator.SimpleCalculator(50, 25, Operation.minus);
            mock_c.Setup(s => s.SimpleCalculator(25, 25, Operation.minus));
            mock_c.Verify(mock => mock.SimpleCalculator(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<Operation>()), Times.AtLeastOnce());
            mock_c.Verify(sa => sa.IsEligable(Operation.minus), Times.AtLeastOnce());
        } 
        [Fact]
        public void isEligable_Should_Return_True_On_Minus()
        {
            SetUpMockObjects();
            var console = new Calculator(mock_fakeConsole.Object, mock_cv.Object);
            var expected = console.IsEligable(Operation.minus);
            Assert.True(expected);
        }
        [Fact]
        public void isEligable_Should_Return_True_On_Plus()
        {
            SetUpMockObjects();
            var console = new Calculator(mock_fakeConsole.Object, mock_cv.Object);
            var expected = console.IsEligable(Operation.plus);
            Assert.True(expected);
        }
        [Fact]
        public void isEligable_Should_Return_True_On_Divide()
        {
            SetUpMockObjects();
            var console = new Calculator(mock_fakeConsole.Object, mock_cv.Object);
            var expected = console.IsEligable(Operation.divide);
            Assert.True(expected);
        }
        [Fact]
        public void isEligable_Should_Return_True_On_Multiply()
        {
            SetUpMockObjects();
            var console = new Calculator(mock_fakeConsole.Object, mock_cv.Object);
            var expected = console.IsEligable(Operation.multiply);
            Assert.True(expected);
        }
        [Fact]
        public void isEligable_Should_Return_False_On_Null()
        {
            SetUpMockObjects();
            var console = new Calculator(mock_fakeConsole.Object, mock_cv.Object);
            Assert.Throws<ArgumentException>(() => console.SimpleCalculator(2.2, 2.3, Operation.Null));
        }
    }
}