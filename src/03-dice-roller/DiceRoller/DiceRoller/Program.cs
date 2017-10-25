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

            //Dice dice = new Dice();
            int total = 0;
            
            

            var dice6 = new Dice(6, "d6");
            for (int i = 0; i < 3; i++)
            {
                int roll = dice6.Roll();
                total += roll;
                Console.WriteLine($"1{dice6.Description}: { roll }");
                
            }

            var dice8 = new Dice(8, "d8");
            for (int i = 0; i < 2; i++)
            {
                int roll = dice8.Roll();
                total += roll;
                Console.WriteLine($"1{dice8.Description}: { roll }");
                
            }
            
           
            Console.WriteLine();
            Console.WriteLine($"Roll total: { total }");
            Console.WriteLine();
            Console.Write("> ");
            
            Console.ReadLine();
        }
    }
}
