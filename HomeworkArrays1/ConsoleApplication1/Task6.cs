using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Task5
    {
        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            int[] rew = new int[length];
            Random rand = new Random();

            for (int i = 0; i < length; i++)
            {
                arr[i] = rand.Next(0, 100);
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine();

            for (int i = 0; i <length; i++)

            {
                rew[length-i-1] = arr[i];

                Console.Write(rew[i] + " ");
            }
           
            Console.WriteLine();

            for (int i = 0; i < length; i++)
            {
                rew[i] = arr[i];
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            // не работи, незнам защо!

        }
    }
}
