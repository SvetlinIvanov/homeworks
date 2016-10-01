using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи първото int число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведи второто int число:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Тяхната сума е:");
            Console.WriteLine(a + b);
        }
    }
}
