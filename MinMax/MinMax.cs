using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Feladat
 *  A feladat két lépésből áll:
1. Konzolról bekérünk egy egész számot (legyen: N), amely egy egész típusú tömb elemeinek számát jelent.  Ezután létre hozzuk ezt a tömböt és feltöltjük -N és +N közé eső véletlen számokkal.
2. Megkeressük a tömbben a legkisebb és a legnagyobb számot és az indexével együtt kiírjuk.
*/

namespace MinMax
{
    class MinMax
    {
        static void Main(string[] args)
        {
            // Változók
            // A tömböt még nem hozzuk létre, mert nem ismerjük a méretét. A C# pedig nem ismeri a dinamikus tömböt.
            int szam,   // Ebben tároljuk a beolvasott számot
                min = int.MaxValue,    // Legkisebb szám értéke; A legnagyobb értéket állítjuk be, hogy az első képzett szám biztosan kisebb legyen nála.
                indMin = 0, // Legkisebb szám indexe
                max = int.MinValue,    // Legnagyobb szám értéke; A legkisebb értéket állítjuk be, hogy az első képzett szám biztosan nagyobb legyen nála.
                indMax = 0; // Legnagyobb szám indexe
            Random rnd = new Random();  // Példányosítjuk a Random osztályt

            // Beolvassuk a számot
            Console.WriteLine("Adjon meg egy természetes számot!");
            szam = int.Parse(Console.ReadLine());

            // Most létre tudjuk hozni a tömböt
            int[] tomb = new int[szam];

            // For ciklussal feltöltjük a tömböt
            for (int i = 0; i < tomb.Length-1; i++)
            {
                tomb[i] = rnd.Next(-szam, szam+1);
            }

            // Megkeressük a tömbben a legkisebb és a legnagyobb számot az indexével 
            for (int i = 0; i < tomb.Length - 1; i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                    indMax = i;
                }
                else if (tomb[i] < max)
                {
                    min = tomb[i];
                    indMin = i;
                }
            }

            // Kiíratás
            Console.WriteLine($"A tömb {tomb.Length} elemű;\nLegkisebb elemének értéke: {min} amelynek indexe: {indMin}\nLegnagyobb elemének értéke: {max} amelynek indexe: {indMax}");

            // Képernyő megállítása
            Console.ReadKey();
        }
    }
}
