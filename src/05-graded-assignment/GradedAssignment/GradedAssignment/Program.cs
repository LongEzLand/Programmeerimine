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
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Taco Palanque");
            Console.WriteLine("1200 Main ST.");
            Console.WriteLine("------------------------------------------------------");
            double subtotal = 1;
            double userInput = 0;

            while (userInput != -1)
            {
                Console.Write("Enter price of food item [-1 to quit]: ");
                userInput = double.Parse(Console.ReadLine());
                subtotal += userInput;
            }

            double gratuity = Math.Round(subtotal * 0.15, 2);
            double total = Math.Round(subtotal - gratuity, 2);
            subtotal = Math.Round(subtotal, 2);
            
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"Subtotal: €{subtotal}");
            Console.WriteLine($"15.00% Gratuity: €{gratuity} ");
            Console.WriteLine($"Total: €{total}");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
    }
}
