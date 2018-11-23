using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Console;
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
                    var c = new Calculator();
                    var i = new Input();
                    WriteLine("-- Enter Value --");
                    double userFirstValue = i.UserInput(ReadLine());
                    WriteLine("-- Enter Second Value --");
                    double userSecondValue = i.UserInput(ReadLine());
                    WriteLine("-- Enter One Of The Following Operations (- + * /) --");
                    WriteLine($"-- {userFirstValue} ? {userSecondValue} --");
                    double calculateValues = c.SimpleCalculator(userFirstValue, userSecondValue);
                    WriteLine($"The Result is: {calculateValues}");
                    UserInput = askUser();
                }
                catch (Exception Ex)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("----------------------------------------");
                    WriteLine(Ex.Message);
                    WriteLine("----------------------------------------");
                    ResetColor();
                }
            }
            return false;
        }
        public string askUser()
        {
            WriteLine("---------------Q to Quit----------------");
            WriteLine("---------------Else Enter---------------");
            string userInputs = Console.ReadLine();
            try
            {
                if (userInputs == "Q")
                {
                    return userInputs;
                } else {
                    return "";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }

}
