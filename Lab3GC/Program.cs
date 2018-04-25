using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3GC
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("please enter a number between 1 and 100");
                int x = int.Parse(Console.ReadLine());

                if (x % 2 == 1)
                {
                    Console.WriteLine($"{x} is odd");
                }
                else if (x <= 25)
                {
                    Console.WriteLine($"{x} is even and less than 25");
                }
                else if (x <= 60)
                {
                    Console.WriteLine($"{x} is even ");
                }
                else
                {
                    Console.WriteLine($"{x} is greater than 60 and is even");
                }

                Console.WriteLine("do you want to continue: y/n");
                string response = (Console.ReadLine());
                if (response.ToLower() == "n")
                {

                    break;

                }


            }
            
        }
    }
}
