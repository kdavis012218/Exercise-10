using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    class Program
    {
        static void Main(string[] args)
            

        {
            float response;


            Console.WriteLine("Welcome to the IncrediCoaster");
            Console.ReadKey();
            Console.WriteLine("You must meet the minimum height requirement to come aboard");
            Console.ReadKey();
            Console.WriteLine("Please enter your height in inches");
            Console.ReadLine();
            response = Console.ReadLine();
            if (response => "54.0")
            {
                Console.WriteLine("You may pass");
            }
            else
                Console.WriteLine("Come back next year when you have grown more....");
        }
    }
}
