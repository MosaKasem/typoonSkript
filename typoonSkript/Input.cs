using System;

namespace Domain
{
    public class Input
    {
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