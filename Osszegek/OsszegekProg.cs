using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Írj egy programot, amely 1-től 100-ig összeadja a számokat egy for ciklus segítségével, és kiírja az eredményt!
 */

namespace Osszegek
{
    class OsszegekProg
    {
        static void Main(string[] args)
        {
            // Változók
            int index = 1,
                osszeg = 0,
                hatar = 100;

            // While ciklus
            while (index <= hatar)
            {
                osszeg += index;
                index++;    // Index növelése
            }

            // Kiíratás
            Console.WriteLine($"A [{1},{hatar}] számok összege: {osszeg}.");
            Console.ReadKey();
        }
    }
}
