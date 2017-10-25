using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class DiceRoller
    {
        public List<DiceRoll> Roll(List<Dice> dices)
        {
            var result = new List<DiceRoll>();

            foreach (var dice in dices)
            {
                result.Add(new DiceRoll(dice.Description, dice.Roll()));
            }

            return result;
            
            //throw new NotImplementedException();
            //^kui sul on koodis on selline rida, siis koodi käivitades lendab lihtsalt vastu taevast. 
        }
    }
}
