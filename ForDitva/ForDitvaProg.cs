using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Írj egy programot, amely for ciklussal kiírja a számokat 20-tól 1-ig csökkenő sorrendben!
 */

namespace ForDitva
{
    class ForDitvaProg
    {
        static void Main(string[] args)
        {
            // Változók
            int alsoHatar = 1,
                felsoHatar = 20;

            // Ciklus
            for (int i = felsoHatar; i > alsoHatar - 1; i--)
            {
                Console.WriteLine($"{i}");
            }

            Console.ReadKey();
        }
    }
}
