using System;
using Domain; // use namespace to reference!
using Xunit;
using Moq;
using System.IO;

namespace typoonSkriptTTD
{
    public class UnitTest2
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
/*         [Fact]
        public void ReturnValue_Is_Run_Twice()
        {
            SetUpMockObjects();
            var app = new App(mock_c.Object, mock_cv.Object, mock_i.Object);
            app.application();
            mock_cv.Verify(m => m.ReturnValue(""), Times.AtLeast(2));
        }
        [Fact]
        public void Make_Sure_Return_Our_Input()
        {
            //Given
            var calView = new CalculatorView();
            var actual = mock_cv.Setup(m => m.ReturnValue("")).Returns("+");
            var expected = "25.0";
            Assert.Equal(expected, actual);
            //When

            //Then
        } */
        [Fact]
        public void DisplayInstructionsPrintToConsole()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var v = new CalculatorView();
                v.ReturnValue("");

                string expected = string.Format("Welcome to Yahtzee\n");
                Assert.Equal(expected, sw.ToString());
            }
        }
        /*         [Fact]
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
                } */

    }
}