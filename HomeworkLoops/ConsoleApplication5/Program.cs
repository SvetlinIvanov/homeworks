using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task6
{
    class Task6

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number N :");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            do
            {
                factorial *= n;
                n--;
            } while (n > 0);
            Console.WriteLine("N! = " + factorial);

             int c = 0;
             while (factorial % 10 == 0)
            {
                factorial= factorial / 10;
                c++;
            } 
            Console.WriteLine("N! is with  " +c+ " zeros");
        }
    
    }
}
