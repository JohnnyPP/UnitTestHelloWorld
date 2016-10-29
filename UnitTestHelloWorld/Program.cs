using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestHelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintToConsole();
        }

        public static string PrintToConsole()
        {
            string output = "Hello world";
            Console.WriteLine(output);

            return output;
        }
    }
}
