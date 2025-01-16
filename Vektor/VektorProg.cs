using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Készítsünk programot, mely a következő feladatokat végzi el:
-  Feltölt egy N elemű tömböt egy és száz közé eső véletlen számokkal. A tömb méretét a
felhasználó határozza meg!
-  Feltöltés után a tömb elemeit a program írja ki a képernyőre!
-  Rendezze a program a tömb elemeit emelkedő sorrendbe!
-  Írja ki a program a rendezett tömb elemeit!
*/

namespace Vektor
{
    internal class VektorProg
    {
        static void Main(string[] args)
        {
            // Változók
            int meret,  // A tömb mérete
                maxMeret = 50,   // A tömb max mérete
                alsoHatar = 1,  // A megengedett legkisebb véletlen szám
                felsoHatar = 100;   // A megengedett legnagyobb véletlen szám

            int[] tomb; // Deklaráljuk a tömböt

            Random rand = new Random(); // Példányosítjuk a Random osztályt

            // Beolvassuk a tömb méretét
            Console.WriteLine($"Adja meg a tömb méretét (legfeljebb {maxMeret} elemű lehet!): ");
            while (!(int.TryParse(Console.ReadLine(), out meret) && meret <= maxMeret))
            {
                Console.WriteLine("Hibás adat, próbálja újra!");
            }
            
            // Létre hozzuk a tömböt
            tomb = new int[meret];

            // Egy ciklussal feltöltjük a tömböt
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rand.Next(alsoHatar, felsoHatar + 1);
            }

            // Egy ciklussal kiíratjuk a tömböt a képernyőre
            Console.WriteLine("\nA rendezetlen tömb:");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i]);
                if (i < tomb.Length - 1) Console.Write(", ");
                else Console.Write(";");
            }

            // Berendezzük a tömböt
            Array.Sort(tomb);

            // Egy ciklussal újra kiíratjuk a tömböt a képernyőre
            Console.WriteLine("\n\nA rendezett tömb:");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i]);
                if (i < tomb.Length - 1) Console.Write(", ");
                else Console.Write(";");
            }

            Console.ReadKey();

        }
    }
}
