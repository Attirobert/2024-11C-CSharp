using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Billentyűzetről kell beolvasni egy kétdimenziós tömb sorainak és oszlopainak számát.  Figyeljen arra, hogy csak egész számot olvashat be!  
Ezután töltse fel a tömböt [-500;500] tartományba eső véletlen egész számokkal!
Ezután számítsa ki a tömb következő adatait:
legkisebb elemének értékét és helyét
legnagyobb elemének értékét és helyét
a pozitív elemek számát
az elemek átlagát
Végül írassa ki a konzolra az adatokat!
*/

namespace TombKalk
{
    internal class TombKalkProg
    {
        static void Main(string[] args)
        {
            // Változók
            int sor = 0,  // sor elemeinek száma
                oszlop = 0, // oszlop elemeinek száma
                minSzam = 0,    // Legkisebb érték
                maxSzam = 0,    // Legnagyobb érték
                minX = 0,   // Legkisebb elem x indexe
                minY = 0,   // Legkisebb elem y indexe
                maxX = 0,   // Legnagyobb elem x indexe
                maxY = 0,   // Legnagyobb elem y indexe
                pozSzam = 0,    // Pozitív számok száma
                sumSzam;    // Elemek összege  

            int[,] tomb;

            // Beolvasás
            sor = Beolvas("Adja meg a sorok számát!");
            oszlop = Beolvas("Adja meg az oszlopok számát!");

            // Létre hozom a tömböt
            tomb = new int[sor, oszlop];

            // A tömb feltöltése
            Feltolt(tomb);

            // Legkisebb és Legnagyobb elem megkeresése
            Legek(tomb, out maxSzam, out maxX, out maxY, out minSzam, out minX, out minY, out pozSzam, out sumSzam);

            // Eredmény kiírása
            Kiir(minSzam, minX, minY, maxSzam, maxX, maxY, tomb.GetLength(0), tomb.GetLength(1), pozSzam, sumSzam);

        }
        private static void Kiir(int minSzam, int minX, int minY, int maxSzam, int maxX, int maxY, int sorok, int oszlopok, int pozSzam, int sumSzam)
        {
            Console.WriteLine($"A tömb adatai:\n - sorok száma: {sorok}\n - oszlopok száma: {oszlopok}\n - elemek száma: {sorok * oszlopok}\n - legkisebb elem értéke: {minSzam}, helye: [{minX}, {minY}]\n - legnagyobb elem értéke: {maxSzam}, helye: [{maxX}, {maxY}]\n - Pozitív elemek száma: {pozSzam}\n - Számok átlaga: {sumSzam/(sorok*oszlopok)}");

            Console.ReadKey();
        }

        private static void Legek(int[,] ptomb, out int pmaxSzam, out int pmaxX, out int pmaxY, out int pminSzam, out int pminX, out int pminY, out int ppozSzam, out int psumSzam)
        {
            // Változók
            pmaxX = pmaxY = pminX = pminY = ppozSzam = psumSzam = 0;
            pmaxSzam = pminSzam = ptomb[0,0]; // Az első elemmel indulok, mert ez még lehet a legkisebb és a legnagyobb is

            // Sorok ciklusa
            for (int i = 0; i < ptomb.GetLength(0); i++)
            {
                // Oszlopok ciklusa
                for (int j = 0; j < ptomb.GetLength(1); j++)
                {
                    if (ptomb[i, j] > pmaxSzam)     // Legnagyobb elem vizsgálata
                    {
                        pmaxSzam = ptomb[i, j];
                        pmaxX = i;
                        pmaxY = j;
                    }
                    else if (ptomb[i, j] < pminSzam)    // Legkisebb elem vizsgálata
                    {
                        pminSzam = ptomb[i, j];
                        pminX = i;
                        pminY = j;
                    }

                    if (ptomb[i, j] > 0)    // Pozitív számok számolása
                    {
                        ppozSzam++;
                    }

                    psumSzam += ptomb[i, j];    // Értékek összeadása az átlag számításhoz
                }
            }
        }

        private static void Feltolt(int[,] ptomb)
        {
            Random rnd = new Random();

            // Sorok ciklusa
            for (int i = 0; i < ptomb.GetLength(0); i++)
            {
                // Oszlopok ciklusa
                for (int j = 0; j < ptomb.GetLength(1); j++)
                {
                    ptomb[i, j] = rnd.Next(-500, 501);
                }
            }
        }

        private static int Beolvas(string v)
        {
            int x = 0;
            bool ok = false;

            do
            {
                try
                {
                    Console.WriteLine(v);
                    x = Convert.ToInt32(Console.ReadLine());
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Valami hiba történt! {e.ToString()};");
                }
            } while (!ok);

            return x;
        }
    }
}
