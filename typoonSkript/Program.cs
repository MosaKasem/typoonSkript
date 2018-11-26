using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Console;

namespace Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                App app = new App();
                while (app.application());
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }
    }
}
