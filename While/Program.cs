using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Számokat olvasunk be, addig, amíg 0-t nem ír be a kezelő
 * A beolvasott számról kiírjuk, hogy páros vagy páratlan.
 */
namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = int.MaxValue;

            while (szam != 0)
            {
                Console.WriteLine("Adjon meg egy egész számot!");
                szam = Convert.ToInt32(Console.ReadLine());
                if (szam % 2 == 0) Console.WriteLine(" A szám páros.");
                else Console.WriteLine("A szám páratlan");

            }
            Console.WriteLine("Köszönöm a játékot!");
            Console.ReadKey();
        }
    }
}
