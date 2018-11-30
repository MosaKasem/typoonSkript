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


        /* Assert.IsType Test */

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

        /* Assert.IsType Test */



        /*         [Fact] // Crashar.
                public void Verify_ReturnValue_Presents_And_Calls_UserInput()
                {
                    // Fråga om denna.
                    SetUpMockObjects();
                    var fakeC = new FakeConsole("2");
                    var calcV = new CalculatorView(fakeC);
                    calcV.ReturnValue("question");
                    mock_fakeConsole.Setup(s => s.WriteLine("question"));
                    mock_cv.Setup(s => s.UserInput("2"));
                    mock_cv.Verify(s => s.UserInput(It.IsAny<string>()), Times.AtLeastOnce());
                } */


        /* Assert.Equal Enums */

        [Fact]
        public void GetInput_Should_Return_PlusEnum_On_StringPlus()
        {
            mock_fakeConsole = new Mock<IConsole>();
            mock_fakeConsole.Setup(s => s.ReadLine()).Returns("+");
            var calcView = new CalculatorView(mock_fakeConsole.Object);
            var actual = calcView.GetInput();
            Operation expected = Operation.plus;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetInput_Should_Return_MinusEnum_On_StringMinus()
        {
            mock_fakeConsole = new Mock<IConsole>();
            mock_fakeConsole.Setup(s => s.ReadLine()).Returns("-");
            var calcView = new CalculatorView(mock_fakeConsole.Object);
            var actual = calcView.GetInput();
            Operation expected = Operation.minus;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetInput_Should_Return_MinusDivide_On_StringDivide()
        {
            mock_fakeConsole = new Mock<IConsole>();
            mock_fakeConsole.Setup(s => s.ReadLine()).Returns("/");
            var calcView = new CalculatorView(mock_fakeConsole.Object);
            var actual = calcView.GetInput();
            Operation expected = Operation.divide;
            Assert.Equal(expected, actual);
        }

        /* Assert.Equal Enums */


        [Fact]
        public void Verify_PresentResult_WasRun_In_SimpleCalculator_Add()
        {
            SetUpMockObjects();
            var calculator = new Calculator(mock_fakeConsole.Object, mock_cv.Object);
            calculator.SimpleCalculator(25.5, 25.5, Operation.plus);
            mock_cv.Setup(calcView => calcView.PresentResult(25));
            mock_cv.Verify(calcV => calcV.PresentResult(It.IsAny<double>()), Times.AtLeastOnce());
        }
        /*         [Fact]
                public void Verify_Add_Was_Run_Inside_SimpleCalculator()
                {
                    // Fråga: Verify Add was run, funkar ej!
                    SetUpMockObjects();
                    var calculator = new Calculator(mock_fakeConsole.Object, mock_cv.Object);
                    calculator.SimpleCalculator(25.0, 25.0, Operation.plus);
                    mock_c.Setup(calc => calc.Add(It.IsAny<double>(), It.IsAny<double>()));
                    mock_c.Verify(m => m.Add(It.IsAny<double>(), It.IsAny<double>()), Times.AtLeastOnce());
                } */
        /*         [Fact]
                public void Verify_Subtract_Was_Run_Inside_SimpleCalculator()
                {
                    SetUpMockObjects();
                    var calculator = new Calculator(mock_fakeConsole.Object, mock_cv.Object);
                    // var calculator = new Calculator(mock_fakeConsole.Object, mock_cv.Object);
                    // calculator.SimpleCalculator(50, 25, Operation.minus);
                    mock_c.Setup(s => s.SimpleCalculator(25, 25, Operation.minus));
                    mock_c.Verify(mock => mock.SimpleCalculator(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<Operation>()), Times.AtLeastOnce());
                    mock_c.Verify(sa => sa.IsEligable(Operation.minus), Times.AtLeastOnce());
                }  */
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