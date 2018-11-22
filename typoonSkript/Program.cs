using System;

namespace Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var user = new Input();
            var firstValue      = user.UserInput(Console.ReadLine());
            var secondValue     = user.UserInput(Console.ReadLine());
            var calculation     = calculator.SimpleCalculator(firstValue, secondValue);
            Console.WriteLine(calculation);
        }
    }
}
