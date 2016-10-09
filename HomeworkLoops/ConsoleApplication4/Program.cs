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
            int d=0,c=0;
            do
            {

                Console.WriteLine("Enter Number: ");
                int e = int.Parse(Console.ReadLine());
                
                c = c + e;
                d = e;
                Console.WriteLine("The sum is: " + c);

            } while (d!=0);
            Console.WriteLine("The End. You enter 0.");
        }
    }
}
