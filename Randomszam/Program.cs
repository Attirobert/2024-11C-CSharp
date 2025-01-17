using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Bekérünk a konzolról egy számot és ennek az értékét megnöveljük egy véletlen számmal.
 */
namespace Randomszam
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;
            Console.WriteLine("Addjon meg egy pozitív egész számot!");
            szam = Convert.ToInt32(Console.ReadLine());

            // A random osztályt példányosítjuk, azaz létrehozunk egy Random típusú objektumot
            Random rd = new Random();

            // A szam értékét megnöveljük a random objektum által generált véletlen számmal
            szam += rd.Next();

            Console.WriteLine("Az új szám? {0}", szam);

            Console.ReadKey();
        }
    }
}
