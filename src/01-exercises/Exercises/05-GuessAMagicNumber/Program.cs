using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GuessAMagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin välja ühe suvalise numbri [1-100]. Proovi see ära arvata :)");

            Random rnd = new Random();
            int randomNr = rnd.Next(1, 101);

            bool succesfulGuess = false;
            
            while (!succesfulGuess)
            {
                Console.Write("Sina ütled: ");
                int userNr = int.Parse(Console.ReadLine());

                if (userNr > randomNr)
                {
                    Console.WriteLine("Minu number on väiksem");
                }
                else if (userNr < randomNr)
                {
                Console.WriteLine("Minu number on suurem");
                } else
                {
                    Console.WriteLine("Arvasid ära. Tubli!");
                    succesfulGuess = true;
                }
            }
            

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

        }
    }
}
