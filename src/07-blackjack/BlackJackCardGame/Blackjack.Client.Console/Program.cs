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

            String nrOfCards = "";
            bool bDeckChosen = false;
            bool bDeckType = false;
            var userPoints = 0;
            var housePoints = 0;
            bool bBusted = false;
                       
            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine();

            while (!bDeckChosen)
            {
                Console.WriteLine("Which kind of deck would you like to play with?");
                Console.WriteLine("Choose: 1 - To play with 36 cards");
                Console.WriteLine("Choose: 2 - To play with 52 cards ");
                Console.WriteLine();

                nrOfCards = Console.ReadLine();

                if (nrOfCards == "1")
                {
                    bDeckType = true;
                    bDeckChosen = true;
                } else if (nrOfCards == "2")
                {
                    bDeckType = false;
                    bDeckChosen = true;
                } else
                {
                    Console.WriteLine("Please enter a valid option");
                    Console.WriteLine();
                }
            }

            var deck = new Deck(bDeckType);
            var table = new GameTable(deck);

            table.DrawCards();
            table.DrawCards();
            Console.WriteLine();
            Console.WriteLine($"You have been dealt: {GetCardDescription(table.userCards[table.userCards.Count - 2])}, {GetCardDescription(table.userCards[table.userCards.Count - 1])}");
            Console.WriteLine($"House has been dealt: {GetCardDescription(table.houseCards[table.houseCards.Count - 2])}, {GetCardDescription(table.houseCards[table.houseCards.Count - 1])}");
            Console.WriteLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose: 1 - To take another card");
            Console.WriteLine("Choose: 2 - To finish ");
            Console.WriteLine();
            var userChoice = Console.ReadLine();

            Console.WriteLine($"I choose: {userChoice}");
            Console.WriteLine();
           
            while (userChoice == "1" && !bBusted)
            {
                table.DrawCards();
                
                Console.WriteLine($"You have been dealt: {GetCardDescription(table.userCards[table.userCards.Count - 1])}");
                Console.WriteLine($"House has been dealt: {GetCardDescription(table.houseCards[table.houseCards.Count - 1])}");
                Console.WriteLine();

                Console.Write("Your cards are: ");
                for (int i=0; i < table.userCards.Count; i++)
                {
                    Console.Write(GetCardDescription(table.userCards[i]));
                    if (i != table.userCards.Count - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine();
                Console.Write("House cards are: ");
                for (int i=0; i < table.houseCards.Count; i++)
                {
                    Console.Write(GetCardDescription(table.houseCards[i]));
                    if (i != table.houseCards.Count - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine();

                userPoints = table.HouseSumOfCards();
                
                if (userPoints > 21)
                {
                    Console.WriteLine($"You busted! You have {userPoints} points");
                    bBusted = true;
                    Console.WriteLine();
                } else
                {
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("Choose: 1 - To take another card");
                    Console.WriteLine("Choose: 2 - To finish ");
                    Console.WriteLine();
                    userChoice = Console.ReadLine();
                }
            }
            userPoints = table.UserSumOfCards();
            housePoints = table.HouseSumOfCards();
            if(!bBusted)
            {
                Console.WriteLine($"You have {userPoints} points vs. house {housePoints} points");
                if (userPoints > housePoints || housePoints > 21)
                {
                    Console.WriteLine("YOU WIN!!");
                    Console.WriteLine();

                }
                else if (housePoints > userPoints)
                {
                    Console.WriteLine("House wins!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }

            } else
            {
                Console.WriteLine($"House had {housePoints} points");
            }

            Console.WriteLine("Press any key");
            Console.ReadKey();

        }

        public static string GetCardDescription (Card card)
        {
            return card.Hidden ? "[?]" : card.Description;
        }
        
    }
}
