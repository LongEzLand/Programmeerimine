using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/roll 3d6 2d8");
            Console.WriteLine();

            Random rnd = new Random();
           
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("1d6: " + rnd.Next(1, 7));
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("1d8: " + rnd.Next(1, 9));
            }
            
           
            Console.WriteLine();
            Console.WriteLine("Roll total: 20");

            Console.WriteLine("Please press any key to continue...");
            Console.ReadLine();
        }
    }
}
