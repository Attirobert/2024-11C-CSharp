using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * A konzol 24 x 80 képernyőre rajzoljunk * (csillag)  karaktereket  véletlenszerű  pozíciókra  (a  legalsó  sort  technikai  okokból  hagyjuk üresen)! A program akkor álljon le, amikor minden pozícióra került * karakter!
*/

namespace Csillag
{
    class CsillagProg
    {
        static void Main(string[] args)
        {
            // Változók
            int sor,    // Ebbe képezzük a sor számát, amibe írni akarunk
                oszlop, // Ebbe képezzük az oszlop számát, amibe írni akarunk
                maxSor = 24,    // A képernyő sorainak szám
                maxOszlop = 80, // A képernyő oszlopainak száma
                maxElem = maxSor * maxOszlop,   // Ennyi pozícióra írhatunk
                elemSzam = 0;   // Ebben számoljuk, hogy hány pozícióra írtunk már

            string jel = "*";   // Ezt a jelet írjuk ki

            bool[,] tomb = new bool[maxSor, maxOszlop]; // Ebben a tömbben jelöljük, hogy írtunk-e már az adott pozícióba

            Random rnd = new Random();  // Példányosítjuk a Random osztályt

            // Feltöltjük tomb-öt false értékekkel, jelezve, hogy még üres a képernyő
            Array.Clear(tomb, maxSor, maxOszlop);

            // Töröljük a képernyőt
            Console.Clear();

            // Kiíratjuk a csillagokat
            do
            {
                // Előállítjuk a véletlen szerű pozíciókat
                sor = rnd.Next(maxSor);
                oszlop = rnd.Next(maxOszlop);

                if (!tomb[sor,oszlop])   // Ha ennek értéke true, akkor 
                {
                    Console.SetCursorPosition(oszlop, sor); // Odapozícionálok a képernyőn
                    Console.Write(jel); // Kiírom a jelet
                    tomb[sor, oszlop] = true;   // Bejelölöm a tömbben, hogy már van itt jel
                    elemSzam++; // Növelem az elemszámot
                }
            } while (elemSzam < maxElem);

            //Console.WriteLine("A kiírás befejeződött");
            Console.ReadKey();
        }
    }
}
