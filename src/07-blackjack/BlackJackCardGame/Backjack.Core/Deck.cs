namespace Backjack.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Deck
    {
        private readonly List<Card> _cards;
        private static Random rnd = new Random();


        public Deck(bool bShortDeck)
        {
            if (bShortDeck)
            {
                this._cards = C36();
            }
            else
            {
                this._cards = C52();
            }
            this.Shuffle(this._cards);
        }

        public static List<Card> C36()
        {
            //36 kaardiga pakis on: 6, 7, 8, 9, 10, J, Q, K, A
            List<Card> shortDeck = new List<Card>();
            String[] faces = { "J", "Q", "K", "A" };

            for (Suite i = 0; i < Suite.NumSuites; i++)
            {
                for (int j=6; j<15; j++)
                {
                    if (j < 11)
                    {
                        shortDeck.Add(new Card(j.ToString(), i, j));
                    } else
                    {
                        int value = 10;
                        if (faces[j-11] == "A")
                        {
                            value = 11;
                        }
                        shortDeck.Add(new Card(faces[j - 11], i, value));
                    }
                }
            }
            return shortDeck;
        }

        public static List<Card> C52()
        {
            //52 kaardiga pakis on: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A
            List<Card> longDeck = new List<Card>();
            String[] faces = { "J", "Q", "K", "A" };

            for (Suite i = 0; i < Suite.NumSuites; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    if (j < 11)
                    {
                        longDeck.Add(new Card(j.ToString(), i, j));
                    }
                    else
                    {
                        int value = 10;
                        if (faces[j - 11] == "A")
                        {
                            value = 11;
                        }
                        longDeck.Add(new Card(faces[j - 11], i, value));
                    }
                }
            }
            return longDeck;
        }

        private void Shuffle(List<Card> deck)
        {
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Card value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }

        public Card Next()
        {
            //TODO: This will blow up if no card left in the deck!
            var card = _cards.ElementAt(0);

            _cards.RemoveAt(0);

            return card;




        }
    }
}