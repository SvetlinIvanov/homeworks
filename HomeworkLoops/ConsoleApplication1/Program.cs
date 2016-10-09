using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2
    
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int N = int.Parse(Console.ReadLine());


            for (int i = 1; i <= N; i++)
            {
               if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(i+",");
                }

                Console.WriteLine();

            }
        }
    }
}
