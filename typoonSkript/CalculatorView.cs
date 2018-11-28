using System;
using System.Linq;
using System.Collections;
using System;
using System.Collections.Generic;

namespace Domain
{
    public interface IConsole
    {
        string ReadLine();
    }
    public class ConsoleWrapper : IConsole
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
    public class CalculatorView : ConsoleWrapper
    {
        public Operation GetInput()
        {
            Console.WriteLine("--Choose operator ( + )( - )( * )( / )");
            string x = ReadLine();
            throw new Exception();
/*             switch (x.ToCharArray()[0])
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
            } */
        }
        public void PresentResult(double presentValue)
        {
            Console.WriteLine(presentValue);
        }
        public double ReturnValue(string Question)
        {
            Console.WriteLine(Question);
            // throw new Exception(); // Fråga hur testar 
            return UserInput(ReadLine());
        }

        private double UserInput(string input)
        {
            if (!double.TryParse(input, out double convertedNumber)) throw new ArgumentException("Must be a numeric value");
            return convertedNumber;
        }
    }
}