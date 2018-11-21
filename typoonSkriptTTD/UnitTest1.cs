using System;
using Domain; // use namespace to reference!
using Xunit;
using Moq;

namespace typoonSkriptTTD
{

    public class UnitTest1
    {
        [Theory]
        [InlineData("50", 50)]
        [InlineData("25", 25)]
        [InlineData("25", 25)]
        [InlineData("250000000000", 250000000000)]
        public void Input_Validator_Make_Sure_Its_Numeric(string value, double expected)
        {
        //Given
        var sut = new Input();
        
        //When
        var actual = sut.UserInput(value);
        //Then
        Assert.Equal(expected, actual);
        }
        // [Fact]
        // public void ValueShouldAdd4And5() => Values_Should_Calculate_Add(4.0, 5.0, 9.0);

/*         [Theory]
        [InlineData(5.5, 5.5, 11.0)]
        [InlineData(25.0, 25.0, 50.0)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Values_Should_Calculate_Add(double x, double y, double expected)
        {
            // actual
            var sut = new Calculator(x, y);
            var actual = sut.Add(x, y);
            // assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-5.0, 0, 0)]
        public void Values_Should_Calculate_Divide(double x, double y, double expected)
        {
            var sut = new Calculator(x, y);
            var actual = sut.Divide(x, y);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(50, 2, 100)]
        [InlineData(50, 4, 200)]
        public void Values_Should_Calculate_Multiply(double x, double y, double expected)
        {
            var sut = new Calculator(x, y);
            var actual = sut.Multiply(x, y);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(5, 5, 3125)]
        [InlineData(5, 10, 9765625)]
        public void Value_Should_Calculate_Elevated(double x, double y, double expected)
        {
            var iCalculatorMock = new Mock<ICalculator>();
            iCalculatorMock.Setup(s => s.Elevated(x, y)).Returns(() => Math.Pow(x, y));
            var sut = new Calculator(x, y);
            var actual = sut.Elevate(iCalculatorMock.Object, x, y);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Value_Should_Calculate()
        {
            //Given
            var mochObj = new Mock<Random>();
            var randomNumber = mochObj.Setup(r => r.Next(1, 100)).Returns(2);

            //When

            //Then
        } */
    }
}
