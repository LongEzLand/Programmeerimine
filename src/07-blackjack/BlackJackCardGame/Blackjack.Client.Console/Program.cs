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
                       
            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine();

            while (!bDeckChosen)
            {
                Console.WriteLine("Which kind of deck would you like to play with?");
                Console.WriteLine("Choose: 1 - To play with 36 cards");
                Console.WriteLine("Choose: 2 - To play with 52 cards ");
                

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

            //Console.WriteLine("Do you want to start the game? Y/N");
            //Console.WriteLine();
            //var starting = Console.ReadLine();

            //if (starting == "N") {
            //    Environment.Exit(0);
            //}
            //else
            //{
                //int userPoints = 0;
                //int housePoints = 0;
                // no need tuleb ju kuskil arvutada, uus klass? hand? kuidas ma arvutan neid?

                
                //TODO: Ühte ja sama masti jagab ainult? 
                Console.WriteLine($"You have been dealt: {GetCardDescription(deck.Next())}, {GetCardDescription(deck.Next())}");
                Console.WriteLine($"House has been dealt: {GetCardDescription(deck.Next())}, {GetCardDescription(deck.Next())}");
                Console.WriteLine();

                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Choose: 1 - To take another card");
                Console.WriteLine("Choose: 2 - To finish ");
                Console.WriteLine();
                var userChoice = Console.ReadLine();

                Console.WriteLine($"I choose: {userChoice}");
                Console.WriteLine();

                var table = new GameTable(deck);


                while (userChoice == "1")
                    {
                        Console.WriteLine($"You have been dealt: {GetCardDescription(deck.Next())}");
                        Console.WriteLine($"House has been dealt: {GetCardDescription(deck.Next())}");
                        Console.WriteLine();

                        Console.WriteLine("What do you want to do?");
                        Console.WriteLine("Choose: 1 - To take another card");
                        Console.WriteLine("Choose: 2 - To finish ");
                        Console.WriteLine();

                
                        //if (userPoints >= 21)
                        //{
                        //    break;
                        //} else if (housePoints <= 21)
                        //{
                        //    break;
                        //}

                    }

                var userPoints = table.UserSumOfCards();
                var housePoints = table.HouseSumOfCards();

            Console.WriteLine($"You have {userPoints} points vs. house {housePoints} points");
                if (userPoints > housePoints)
                {
                    Console.WriteLine("YOU WIN!!");
                    Console.WriteLine();

                } else if (housePoints > userPoints)
                {
                    Console.WriteLine("House wins!");
                    Console.WriteLine();
                } else
                {
                    Console.WriteLine("It's a tie!");
                }
                


            

            //}

            Console.WriteLine("Press any key");
            Console.ReadKey();

        }

        public static string GetCardDescription (Card card)
        {
            return card.Hidden ? "[?]" : card.Description;
        }
        
    }
}
