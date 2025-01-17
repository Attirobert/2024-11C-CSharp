using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Feladat:
 * Kérjünk be egy számot és írjuk ki, hogy prímszám-e!
 */

#region Megoldás menete
/* Mivel egy szám akkor prím, ha az 1-et és önmagát leszámítva nincs osztója a természetes számok körében. Ugyan akkor a felénél nagyobb számok biztosan nem osztói.
* Ezért megnézzük maradékos osztással, hogy a felénél kisebb számok között van-e osztója.
* Ha van, akkor nem prím, ha nincs, akkor prím.
*/
#endregion Megoldás menete

namespace Primszam
{
    internal class PrimszamProg
    {
        static void Main(string[] args)
        {
            int szam,   // Ebbe olvassuk be egészre konvertálva a számot
                oszto;  // Ez a változó tárolja az osztó aktuális értékét

            bool prim = true;   // Ez a változó jelzi, hogy a szám prím-e. Induláskor mindegyik számról feltételezzük, hogy prím.

            string msg = string.Empty; // Ebben a változóban tároljuk a kiírandó üzenet egy részét. Alapértelmezésben üres.

            Console.WriteLine("Adjon meg egy egész számot!");
            szam = Convert.ToInt32(Console.ReadLine());

            oszto = szam / 2;   // Egész számok körében végezzük az osztást, így egész számot kapunk eredményül. 

            while (oszto > 3 && prim)   // Az 1, 2, 3 értékeket nem vizsgáljuk, mivel tudjuk, hogy azok prímek.
            {
                if (szam % oszto == 0) prim = false;    // Ha az osztási maradék 0, akkor nem prím és befejeződik a keresés.
                oszto--;    // Beállítjuk az osztó új értékét
            }

            /* Az alábbit terciális kifejezésnek is nevezik. Lényegében egy if - else szerkezetnek a rövidített formája.  
             * Működése: ha a "?" előtti logikai kifejezés értéke igaz, akkor a "?" utáni értéket adja tovább, egyébként pedig a ":" utánit.*/
            msg = prim ? "prím" : "nem prím";

            Console.WriteLine($"A {szam} {msg}szám.");

            Console.ReadKey();
        }
    }
}
