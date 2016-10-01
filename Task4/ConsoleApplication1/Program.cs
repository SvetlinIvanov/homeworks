using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи първото int число a :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведи второто int число b :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Остатъкът от целочисленото делене a/b e :");
            Console.WriteLine(a%b);
        }
    }
}
