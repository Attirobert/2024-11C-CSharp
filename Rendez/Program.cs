using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendez
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;   // Ebbe olvasom be a számot
            do
            {
                // Üzenet a használónak
                Console.WriteLine("Írjon be egy egész számot!");
                szam = Convert.ToInt32(Console.ReadLine());
                if (szam % 2 == 0)
                {
                    Console.WriteLine("A szám páros");
                }
                else Console.WriteLine("A szám páratlan ");
                Console.ReadKey();

            } while (szam == 0);
            // 
            Console.WriteLine("Köszönöm a játékot!");
            Console.ReadKey();
        }

    }
}

