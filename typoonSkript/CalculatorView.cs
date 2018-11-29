using System;
using System.Linq;
using System.Collections;
using System;
using System.Collections.Generic;

namespace Domain
{
    public class CalculatorView : ConsoleWrapper
    {
        private IConsole _console;
        public CalculatorView(IConsole input)
        {
            this._console = input;
        }
        public Operation GetInput()
        {
            Console.WriteLine("--Choose operator ( + )( - )( * )( / )");
            string x = this._console.ReadLine();
            switch (x.ToCharArray()[0])
            {
                case '+':
                    return Operation.plus;
                case '-':
                    return Operation.minus;
                case '*':
                    return Operation.multiply;
                case '/':
                    return Operation.divide;
                default:
                    return Operation.Null;
            }
        }
        public void PresentResult(double presentValue)
        {
            Console.WriteLine(presentValue);
        }
        public double ReturnValue(string Question)
        {
            Console.WriteLine(Question);
            // throw new Exception(); // Fråga hur testar 
            return UserInput(this._console.ReadLine());
        }

        private double UserInput(string input)
        {
            if (!double.TryParse(input, out double convertedNumber)) throw new ArgumentException("Must be a numeric value");
            return convertedNumber;
        }
    }
}