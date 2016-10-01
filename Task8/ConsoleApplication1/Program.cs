using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи стринг:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Въведи цяло число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("На позиция " + a + " (с начало от 0) в стринга се намира буквата :");
            string str2 = str1.Substring(a,1);
            Console.WriteLine(str2);


        }
    }
}
