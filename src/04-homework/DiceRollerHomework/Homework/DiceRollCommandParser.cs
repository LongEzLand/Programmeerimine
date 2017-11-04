using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class DiceRollCommandParser
    {
       
        public List<Dice> ParseCommand (string userInput)
        {
            int i = 0;
            var returnList = new List<Dice>();
            string[] userDices = userInput.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

            foreach (var userDice in userDices)
            {
                int count;
                int sides; 
                string description;
                if (i > 0)
                 {
                    string[] numbers = userDice.Split('d');
                    count = int.Parse(numbers[0]);
                    sides = int.Parse(numbers[1]);
                    description = "d" + numbers[1];

                    for (var j = 0; j < count; j++)
                    {
                        returnList.Add(new Dice(sides, description));
                    }
                 }
                i++;
            }

            return returnList;
        }
    }
}
