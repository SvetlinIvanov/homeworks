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

            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            arr[0] = 1;
            arr[1] = 1;

            Console.WriteLine();
            Console.WriteLine((1) + " " + arr[0]);
            Console.WriteLine((2) + " " + arr[1]);

            for (int i = 2; i < arr.Length; i++)
            {
                 arr[i] = arr[i-1] + arr[i-2];
                 Console.WriteLine((i+1) + " "+ arr[i]);
            }

            //  по някаква причина работи коректно само до 46 индекс
         

        }
    }
}
