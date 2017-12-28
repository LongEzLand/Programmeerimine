namespace Blackjack.Client.Console
{
    using Backjack.Core;
    using System;
    using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
            // All aces are 11 points. IRL, one can choose whether it is 1 or 11
            // When user draws a card, house always draws one as-well. IRL, house can decide

            var cards = new List<Card>
            {
                new Card("4", Suite.Club, 4),
                new Card("6", Suite.Heart, 6),
                new Card("8", Suite.Spade, 8),
                new Card("J", Suite.Diamond, 10, true),
                new Card("4", Suite.Spade, 4),
                new Card("T", Suite.Heart, 10, true)

            };

            var deck = new Deck(cards);

           
            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine();

            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.Next())}, {GetCardDescription(deck.Next())}");
            Console.WriteLine($"House has been dealt: {GetCardDescription(deck.Next())}, {GetCardDescription(deck.Next())}");
            Console.WriteLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose: 1 - To take another card");
            Console.WriteLine("Choose: 2 - To finish ");
            Console.WriteLine();

            Console.WriteLine("I choose: 1");
            Console.WriteLine();

            
            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.Next())}");
            Console.WriteLine($"House has been dealt: {GetCardDescription(deck.Next())}");
            Console.WriteLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose: 1 - To take another card");
            Console.WriteLine("Choose: 2 - To finish ");
            Console.WriteLine();

            Console.WriteLine("I choose: 2");
            Console.WriteLine();

            Console.WriteLine("You have 14 points vs. house 17 points");
            Console.WriteLine("House wins!");
            Console.WriteLine();


            Console.WriteLine("Press any key");
            Console.ReadKey();

        }

        public static string GetCardDescription (Card card)
        {
            return card.Hidden ? "[?]" : card.Description;
        }
    }
}
