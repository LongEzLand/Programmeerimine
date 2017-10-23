using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen kalkulaatori programm. Ütle mulle 2 numbrit ja ma ütlen Sulle nende summa.");
            Console.Write(Environment.NewLine);



            Console.Write("Esimene number: ");
            int firstNr = int.Parse(Console.ReadLine());
            Console.Write("Teine number: ");
            int secondNr = int.Parse(Console.ReadLine());

            int sum = firstNr + secondNr;

            Console.WriteLine($"Tulemus on: {sum}");

           
            Console.Write(Environment.NewLine);
            Console.WriteLine("Press any key to continue..");
            Console.ReadLine();
        }
    }
}
