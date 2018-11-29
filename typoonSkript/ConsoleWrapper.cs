using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Domain
{

    public interface IConsole
    {
        string ReadLine();
        // string WriteLine();
    }
    public class ConsoleWrapper : IConsole
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
/*         public string WriteLine(string msg)
        {
            Console.WriteLine(msg);
        } */
    }
}