using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Készíts egy programot, amely while ciklussal kiírja az összes páros számot 1-től 20-ig!
 */

namespace ParosSzamok
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változót definiálunk
            int szam = 1;

            // Ciklus vezérlő szerkezet
            while (szam < 21)
            {
                if (szam % 2 == 0)
                {
                    Console.WriteLine($"A {szam} páros.");
                }

                szam++;
            }

            Console.ReadKey();
        }
    }
}
