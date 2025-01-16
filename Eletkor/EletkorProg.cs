using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Készítsünk programot, mely a következő feladatokat végzi el!
Bekéri a felhasználó nevét, valamint születésének évét. Kiszámítja a felhasználó életkorát. Ezután egy
üres képernyőn, melynek kék a háttere, a képernyő közepén megjeleníti sárga színnel a felhasználó
nevét, majd alatta piros színnel a felhasználó életkorát.
*/

namespace Eletkor
{
    internal class EletkorProg
    {
        static void Main(string[] args)
        {
            // Változók
            string nev; // Felhasználó neve
            int eletkor,    // Felhasználó életkora, számított
                evMin = 2000,      // A legkorábbi születési évszám, amit elfogadunk
                eletkorJegyek = 2,  // Életkor jegyeinek szám; a kiíratás pozícionálásához van rá szükség
                szulEv,     // Születési év; beolvassuk
                screenX,    // A vízszintes pozíció, ahonnan kell kezdeni a kiírást
                screenY;   // A függőleges pozíció, ahonnan kell kezdeni a kiírást

            // Név beolvasása
            Console.WriteLine("Kérem, adja meg a nevét: ");
            nev = Console.ReadLine();

            // Születési év beolvasása
            Console.WriteLine("Kérem, adja meg a születési évét: ");
            while (!(int.TryParse(Console.ReadLine(), out szulEv) && szulEv >= evMin))
            {
                Console.WriteLine("Hibás adat, ismételje meg!");
            }

            // Életkor kiszámítása
            // Ehhez a statikus DateTime osztály következő tulajdonságait használjuk:
            //  Now - A gép rendszerdátuma
            //  Now.Year - A dátumból az évszámot adja meg.
            eletkor = DateTime.Now.Year - szulEv;

            // Kiírási pozíciók kiszámítása
            screenX = (Console.WindowWidth - nev.Length) / 2;
            screenY = Console.WindowHeight / 2;

            // Képernyő beállítások a kiíratáshoz
            Console.BackgroundColor = ConsoleColor.Blue;    // Háttérszín
            Console.ForegroundColor = ConsoleColor.Yellow;  // Szövegszíne

            // Név kiírása
            Console.Clear();    // Töröljük a képernyőt
            Console.SetCursorPosition(screenX, screenY);
            Console.WriteLine(nev);

            // Kiírási pozíciók újra számítása
            // Erre azért van szükség, mert egyébként a sor elején kezdené
            screenX = (Console.WindowWidth - eletkorJegyek) / 2;
            screenY = Console.WindowHeight / 2 + 1;

            // Életkor kiíratása
            Console.ForegroundColor = ConsoleColor.Red;  // Szövegszíne
            Console.SetCursorPosition(screenX, screenY);
            Console.WriteLine(eletkor);

            
            Console.ReadKey();
        }
    }
}
