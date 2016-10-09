using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number N :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number K :");
            int k = int.Parse(Console.ReadLine());


            if (1 < k && k < n)
            {
                int m = n - k;
                BigInteger factorial1 = 1;
                BigInteger factorial2 = 1;
                BigInteger factorial3 = 1;

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
                Console.WriteLine("K! = " + factorial2);

                do
                {
                    factorial3 *= m;
                    m--;
                } while (m > 0);
                Console.WriteLine("(N-K)! = " + factorial3);

                Console.WriteLine("N!*K!/(N-K)! = " + factorial1 * factorial2 / factorial3);
            }
            else
                Console.WriteLine("Condition 1<K<N is not True!");
        }
    
    }
}
