using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1

{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int N = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= N; i++)
            {
                Console.Write(i+",");
            }
          Console.WriteLine();
        }
    }
}
