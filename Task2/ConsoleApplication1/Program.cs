using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string:");
            string any = Console.ReadLine();
            string fix = "Hello";
            Console.WriteLine("Is your string is equal to Hello?");
            Console.WriteLine(any == fix);

        }
    }
}
