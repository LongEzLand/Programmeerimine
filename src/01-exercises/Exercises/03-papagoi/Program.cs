using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_papagoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen papagoi programm. Ütle mulle midagi ja ma kordan selle sulle tagasi...");
            Console.Write(Environment.NewLine);



            Console.Write("Sina ütled: ");
            String inputWord = Console.ReadLine();

            Console.WriteLine("Mina ütlen: " + inputWord);
            Console.Write(Environment.NewLine);
            Console.WriteLine("Press any key to continue..");
            Console.ReadLine();


        }
    }
}
