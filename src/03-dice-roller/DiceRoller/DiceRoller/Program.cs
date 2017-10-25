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
            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine();

            Random rnd = new Random();
            int total = 0;

            for (int i = 0; i < 3; i++)
            {
                int roll = rnd.Next(1, 7);
                total += roll;
                Console.WriteLine($"1d6: { roll }");
                
            }

            for (int i = 0; i < 2; i++)
            {
                int roll = rnd.Next(1, 9);
                total += roll;
                Console.WriteLine($"1d6: { roll }");
                
            }
            
           
            Console.WriteLine();
            Console.WriteLine($"Roll total: { total }");
            Console.WriteLine();
            Console.Write("> ");
            
            Console.ReadLine();
        }
    }
}
