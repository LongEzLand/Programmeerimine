using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a discount calculator and please insert a sum ($): ");

            double userInput = double.Parse(Console.ReadLine());

            if (userInput > 50)
            {
                double discountsum = userInput * 0.95;
                Console.WriteLine("Your discount percent is 5% and have to pay: " + discountsum);
            }
            Console.WriteLine("Enter any key to continue...");
            Console.ReadLine();
        }
    }
}
