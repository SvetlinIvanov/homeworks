using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи  double число a :");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведи  int число b :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(" a/b = :");
            Console.WriteLine(a/b);
        }
    }
}
