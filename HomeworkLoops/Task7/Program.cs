using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number N :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number K :");
            int k = int.Parse(Console.ReadLine());

           
            if (1<k && k<n)
            {
                BigInteger factorial1 = 1;
                BigInteger factorial2 = 1;

                do
                {
                    factorial1 *= n;
                    n--;
                } while (n > 0);
                Console.WriteLine("N! = " + factorial1);
                do
                {
                    factorial2 *= k;
                    k--;
                } while (k > 0);
                Console.WriteLine("K! = " +factorial2);

                Console.WriteLine("N!/K! = " + factorial1 / factorial2);
            }
            else
                Console.WriteLine("Condition 1<K<N is not True!");
        }
    }
}
