using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Állítsunk elő véletlenszerűen egy egész számot a [100, 1000] intervallumból, majd írjuk ki a számot, valamint hogy páros-e!
 */

namespace RandPar
{
    internal class RandParProg
    {
        static void Main(string[] args)
        {
            // Változók 
            int szam = 0;   // Ebbe a változóba képezzük a véletlen számot
            Random rnd = new Random();  // A Random osztály példányosítása

            szam = rnd.Next(100, 1000); // A véletlenszám >= 0 és < 1000
            if (szam % 2 == 0) Console.WriteLine($"A {szam} páros");
            else Console.WriteLine($"A {szam} páratlan");

            Console.ReadKey();
        }
    }
}
