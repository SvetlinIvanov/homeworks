using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

          
            int[] arr = new int[10];
            Random rand = new Random();
            double a = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
                Console.Write(arr[i]+";  ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = arr[i]*(i+1)*10;
              
                Console.Write(arr[i]+"; ");
            }

            Console.WriteLine();
        

        }
    }
}
