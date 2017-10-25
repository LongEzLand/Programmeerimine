using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class DiceRoll
    {
        public int Value { get; }
        public string Dice { get; }

       public DiceRoll(string dice, int value)
        {
            this.Dice = dice;
            this.Value = value;

        }
    }
}
