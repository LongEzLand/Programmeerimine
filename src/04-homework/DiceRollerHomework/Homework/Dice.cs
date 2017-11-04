using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Dice
    {

        private int Sides { get; }
        public string Description { get; }
        private static readonly Random Random = new Random(); 
        

        public Dice(int sides, string description)
        {
            this.Description = description;
            this.Sides = sides;
        
        }

        public int Roll()
        {
            return Random.Next(1, this.Sides + 1);
        }
    }
}
