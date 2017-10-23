using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_4x4Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.Write(i + " | ");
                for (int j = 1; j <= 4; j++)
                {
                    if (i > 0) Console.Write(i * j + " | ");
                    else Console.Write(j + " | ");
                }
                Console.Write("\n");
                Console.Write("----------------");
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
