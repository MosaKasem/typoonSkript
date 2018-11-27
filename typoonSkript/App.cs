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
        Operation operation = Operation.Null;
        public bool application()
        {
            bool UserInput = false; // False
            while (!UserInput)
            {
                try
                {
                    var v = new CalculatorView();
                    var c = new Calculator(v);
                    var i = new Input();
                    var firstValue = v.ReturnValue("--Enter Value--");
                    var seconValue = v.ReturnValue("--Enter Second Value--");
                    c.SimpleCalculator(firstValue, seconValue);
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
