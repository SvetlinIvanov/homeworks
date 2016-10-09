using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:");
            int numInt = int.Parse(Console.ReadLine());

            switch (numInt)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:

                    if (numInt % 2 == 0)
                    {
                        Console.WriteLine("Even");
                    }
                    else
                    {
                        Console.WriteLine("Odd");
                    }
                    break;

                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:

                    if (numInt % 3 == 0)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                    break;

                default:

                      if (numInt == 0)
                        {
                            Console.WriteLine("Zero");
                        }
                        else if (numInt > 0)
                        {
                            Console.WriteLine("Positive");
                        }
                        else
                        {
                            Console.WriteLine("Negative"); 
                        };
                   break;
            }
        }
    }
}
