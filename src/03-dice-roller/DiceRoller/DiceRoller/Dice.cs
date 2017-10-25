using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Dice
    {
        private Random Random { get; }
        private int Sides { get; }
        public string Description { get; }

        public Dice(int sides, string description)
        {
            this.Description = description;
            this.Sides = sides;
            this.Random = new Random();
        }

        public static Dice D6 => new Dice(6, "d6");
        public static Dice D8 => new Dice(8, "d8");
        // saaks ka nii, et oleks public static Dice D8 { return new Dice (8, "d8"); }


        public int Roll()
        {
            return this.Random.Next(1, this.Sides + 1);

        }
    }
}
