using System;

namespace Domain
{
    public class Input
    {
        public bool Exit()
        {
            Console.WriteLine("---------------Q to Quit----------------");
            Console.WriteLine("---------------Else Enter---------------");
            string input = Console.ReadLine();
            if (input == "Q") return true;
            return false;
        }
    }
}