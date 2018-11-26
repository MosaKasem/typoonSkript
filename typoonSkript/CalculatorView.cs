using System;
using System.Linq;
using System.Collections;
using System;
using System.Collections.Generic;

namespace Domain
{
    public class CalculatorView
    {
        public Operation GetInput()
        {
            Console.WriteLine("--Choose operator ( + )( - )( * )( / )");
            string x = Console.ReadLine();
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
            return UserInput(Console.ReadLine());

        }
        private double UserInput(string input)
        {
            if (!double.TryParse(input, out double convertedNumber)) throw new ArgumentException("Must be a numeric value");
            return convertedNumber;
        }
    }
}