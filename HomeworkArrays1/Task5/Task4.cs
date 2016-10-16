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
            Console.WriteLine("Въведи дължина на масива:");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Random rand = new Random();
            double a = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
                Console.Write(arr[i]+ "; ");
            }

            Console.WriteLine();
            Console.WriteLine("Въведи търсеното число:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    Console.WriteLine("Числото е на " +(i+1)+ " позиция.");
                }
               
            }
            Console.WriteLine();
            

        }
    }
}
