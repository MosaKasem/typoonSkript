using System;

namespace Domain
{
    public class Input
    {
        public double UserInput(string input)
        {
            if (!double.TryParse(input, out double convertedNumber)) throw new ArgumentException("Must be a numeric value");
            return convertedNumber;
        }
        public string Exit()
        {
            Console.WriteLine("---------------Q to Quit----------------");
            Console.WriteLine("---------------Else Enter---------------");
            string input = Console.ReadLine();
            if (input == "Q") return input;
            return input = "";
        }
    }
}