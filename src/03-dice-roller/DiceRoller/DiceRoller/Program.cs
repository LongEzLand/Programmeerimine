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

            DiceRoller diceRoller = new DiceRoller();
            List<DiceRoll> diceRolls = diceRoller.Roll(
                new List<Dice> { Dice.D6, Dice.D6, Dice.D6, Dice.D8, Dice.D8 });

            foreach (var diceRoll in diceRolls)
            {
                Console.WriteLine($"1{diceRoll.Dice}: {diceRoll.Value}");
            }

            //Dice dice = new Dice();
            int total = 0;


            /* Vana versioon:
            var dice6 = Dice.D6;
            for (int i = 0; i < 3; i++)
            {
                int roll = dice6.Roll();
                total += roll;
                Console.WriteLine($"1{dice6.Description}: { roll }");
            }

            var dice8 = Dice.D8;
            for (int i = 0; i < 2; i++)
            {
                int roll = dice8.Roll();
                total += roll;
                Console.WriteLine($"1{dice8.Description}: { roll }");
            }
            */

            Console.WriteLine();
            Console.WriteLine($"Roll total: { diceRolls.Sum(x => x.Value) }");
            Console.WriteLine();
            Console.Write("> ");
            
            Console.ReadLine();
        }
    }
}
