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
            int[] arr1 = new int[length];
            int[] arr2 = new int[length];
            Random rand = new Random();
       
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(0, 100);
                Console.Write(arr1[i]+" ");

            }

            Console.WriteLine();

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = arr1[i];
              Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
            


        }
    }
}
