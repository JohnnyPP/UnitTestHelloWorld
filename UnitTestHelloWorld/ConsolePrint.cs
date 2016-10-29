using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestHelloWorld
{
    public class ConsolePrint
    {
        public static string PrintToConsoleFromClass(string writeLine)
        {
            Console.WriteLine(writeLine);

            return writeLine;
        }
    }
}
