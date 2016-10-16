using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkArrays1
{
    class Task1
    {
        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Random rand = new Random();
            double a = 0;
        
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
                Console.WriteLine(arr[i]);
            }

            for   (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    a = arr[i] + a;
                }

                else a = a + 0;
                
            }
            Console.WriteLine();
            Console.WriteLine(a);


        }
        }
    }

