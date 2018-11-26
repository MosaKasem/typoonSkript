using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
// using static System.Console;
namespace Domain
{
    public class App
    {
        public bool application()
        {

            string UserInput = ""; // False
            while (UserInput != "Q")
            {
                try
                {
                    // ICalculator read;
                    var c = new Calculator();
                    var i = new Input();
                    Console.WriteLine("-- Enter Value --");
                    double userFirstValue = i.UserInput(Console.ReadLine());
                    Console.WriteLine("-- Enter Second Value --");
                    double userSecondValue = i.UserInput(Console.ReadLine());
                    Console.WriteLine("-- Enter One Of The Following Operations (- + * /) --");
                    Console.WriteLine($"-- {userFirstValue} ? {userSecondValue} --");
                    double calculateValues = c.SimpleCalculator(userFirstValue, userSecondValue);
                    Console.WriteLine($"The Result is: {calculateValues}");
                    UserInput = i.Exit();
                }
                catch (Exception Ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine(Ex.Message);
                    Console.WriteLine("----------------------------------------");
                    Console.ResetColor();
                }
            }
            return false;
        }
    }

}
