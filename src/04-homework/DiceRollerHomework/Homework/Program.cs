using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("> ");
            Console.WriteLine();

            DiceRoller diceRoller = new DiceRoller();
            DiceRollCommandParser CommandParser = new DiceRollCommandParser();
            //userInput peab siis olema stiilis: /roll 4d4 6d6 8d8
            var userInput = Console.ReadLine();
            List<Dice> diceList = CommandParser.ParseCommand(userInput);
            List<DiceRoll> diceRolls = diceRoller.Roll(diceList);
            
            foreach (var diceRoll in diceRolls)
            {
                Console.WriteLine($"1{diceRoll.Dice}: {diceRoll.Value}");
            }
            
            Console.WriteLine();
            Console.WriteLine($"Total: {diceRolls.Sum(x => x.Value)}");
            Console.WriteLine();
            Console.WriteLine("> ");
            Console.ReadLine();
        }
    }
}
