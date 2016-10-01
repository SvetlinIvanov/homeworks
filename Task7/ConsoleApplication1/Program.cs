using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string 1:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter string 2:");
            string str2 = Console.ReadLine();
            Console.WriteLine("If result is not -1, string 1 contains string 2");  
            Console.WriteLine("starting  from specified below position (incl.0).");
            Console.WriteLine(str1.IndexOf(str2));
            



        }
    }
}
