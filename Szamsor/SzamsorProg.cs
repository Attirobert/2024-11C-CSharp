using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Írj egy programot, amely for ciklussal kiírja a számokat 1-től 10-ig!
 */

namespace Szamsor
{
    class SzamsorProg
    {
        static void Main(string[] args)
        {
            // For (határozott lépésszámú) ciklussal iratom ki a számokat
            for (int i = 1; i <= 10; i++)
            {
                // Megnézzük, hogy páros-e a szám
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Az {i} szám páros.");
                }
            }

            Console.ReadKey();
        }
    }
}
