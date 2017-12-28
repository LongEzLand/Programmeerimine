using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjack.Core
{
    public class GameTable
    {
        public List<Card> userCards;
        public List<Card> houseCards;

        private Deck deck;

        public GameTable(Deck _deck)
        {
            deck = _deck;
            userCards = new List<Card>();
            houseCards = new List<Card>();
        }

      

        public void DrawCards()
        {
            //Get player cards
            userCards.Add(this.deck.Next());
            houseCards.Add(this.deck.Next());

            //Unhide all cards but last
            for (int i=0; i<houseCards.Count(); i++)
            {
                houseCards.ElementAt(i).Hidden = false;
            }
            if (houseCards.Count() > 1)
            {
                houseCards.Last().Hidden = true;
            }
        }

        public int UserSumOfCards()
        {
            int userPoints = 0;

            for (int i=0; i < userCards.Count(); i++)
            {
                userPoints += userCards.ElementAt(i).GetCardPoints();
            }
            return userPoints;    
        }
        public int HouseSumOfCards()
        {
            int housePoints = 0;

            for (int i = 0; i < houseCards.Count(); i++)
            {
                housePoints += houseCards.ElementAt(i).GetCardPoints();
            }
            return housePoints;
        }
    }
}
