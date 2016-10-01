using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пресмятане лице на триъгълник.");
            Console.WriteLine("Въведи дължина на страна(мм):");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведи дължина на височинта към страната(мм):");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Лицето е(мм^2):");
            Console.WriteLine(a*h*0.5);
        }
    }
}
