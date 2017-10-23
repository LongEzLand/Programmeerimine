using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ExcusesUsingForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string[] excuses = new[] { "Koer sõi kodutöö ära", "Ema ei luba arvutit kasutada", "Paha oli olla" };
            int i = 0;
                foreach(string element in excuses)
                {
                    Console.WriteLine($"{i + 1}. {element}");
                i++;

                }

                Console.ReadLine();
            }
        }
    }

