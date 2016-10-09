using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Task3

    {
        static void Main(string[] args)
        {
          
  
                Console.WriteLine("Please enter 5 integer numbers");
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                int number3 = int.Parse(Console.ReadLine());
                int number4 = int.Parse(Console.ReadLine());
                int number5 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (number1 > number2 && number1 > number3 && number1 > number4 && number1 > number5)
                {
                    Console.WriteLine("Biggest number is "+ number1);
                }
                else if (number2 > number1 && number2 > number3 && number2 > number4 && number2 > number5)
                {
                    Console.WriteLine("Biggest number is " + number2);
                }
                else if (number3 > number1 && number3 > number2 && number3 > number4 && number3 > number5)
                {
                    Console.WriteLine("Biggest number is " + number3);
                }
                else if (number4 > number1 && number4 > number2 && number4 > number3 && number4 > number5)
                {
                    Console.WriteLine("Biggest number is " + number4);
                }
                else
                {
                    Console.WriteLine("Biggest number is " + number5);
                }


            if (number1 < number2 && number1 < number3 && number1 < number4 && number1 < number5)
            {
                Console.WriteLine("Smallest number is " + number1);
            }
            else if (number2 < number1 && number2 < number3 && number2 < number4 && number2 < number5)
            {
                Console.WriteLine("Smallest number is " + number2);
            }
            else if (number3 < number1 && number3 < number2 && number3 < number4 && number3 < number5)
            {
                Console.WriteLine("Smallest number is " + number3);
            }
            else if (number4 < number1 && number4 < number2 && number4 < number3 && number4 < number5)
            {
                Console.WriteLine("Smallest number is " + number4);
            }
            else
            {
                Console.WriteLine("Smallest number is " + number5);
            }
        }
    }
}
