using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an Card:");
            string Card = Console.ReadLine();

            if (Card=="2"||Card=="3"||Card=="4"||Card=="5"||Card=="6"||Card=="7"||Card=="8"
               ||Card=="9"||Card=="10"||Card=="J"||Card=="Q"||Card=="K"||Card=="A")

            { 
                Console.WriteLine("Card is valid:");
            }
               
            else
                {
                    Console.WriteLine("Card is invalid");
                }

          }
    }
}
