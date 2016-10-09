using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Task4

    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Results ");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0 || i % 11 == 0)
                {
                    Console.Write(i + ", ");
                }

            }
            Console.WriteLine();
            Console.WriteLine("While Results ");
            int a = 1;

            while (a<=100)
            {
                if (a % 7 == 0 || a % 11 == 0)
                {
                    Console.Write(a + ", ");
                }

                a++;
            }
            Console.WriteLine();
            Console.WriteLine("Do-While Results ");
            int b = 1;
            do
            {
               if (b % 7 == 0 || b % 11 == 0)
                {
                    Console.Write(b + ", ");
                }
                b++;
            } while (b<100);
            Console.WriteLine();
        }
    }
}
