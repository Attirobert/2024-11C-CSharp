using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Bekérünk egy számot a billentyűzetről, ha nagyobb mint nulla, akkor kiírjuk, hogy pozitív.
 */
namespace Feltetel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók
            int szam = 0;

            // Adat beolvasása és konvertálása
            Console.WriteLine("Adjon meg egy pozitív egész számot!");
            szam = Convert.ToInt32(Console.ReadLine());

            if (szam > 0) Console.WriteLine("A szám pozitív");
            else if (szam == 0) Console.WriteLine("A szám nulla");
                else Console.WriteLine("A szám negatív");

            Console.ReadKey();
        }
    }
}
