using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
/*
 * Billentyűzetről kell beolvasni a mátrix sorainak és oszlopainak számát.  Figyeljen arra, hogy csak egész számot olvashat be!  Ezután töltse fel a mátrixot [-1000;1000] tartományba eső véletlen egész számokkal!
Végül írassa ki konzolra a mátrix legkisebb és legnagyobb elemének értékét és helyét!
*/
namespace Matrix
{
    class MatrixProg
    {
        static void Main(string[] args)
        {
            // Változók
            int sor,  // sor elemeinek száma
                oszlop, // oszlop elemeinek száma
                minSzam,    // Legkisebb érték
                maxSzam,    // Legnagyobb érték
                minX,   // Legkisebb elem x indexe
                minY,   // Legkisebb elem y indexe
                maxX,   // Legnagyobb elem x indexe
                maxY;   // Legnagyobb elem y indexe

            int[,] tomb;

            // Beolvasás
            sor = Beolvas("Adja meg a sorok számát!");
            oszlop = Beolvas("Adja meg az oszlopok számát!");

            // Létre hozom a tömböket
            tomb = new int[sor, oszlop];

            // A tömb feltöltése
            Feltolt(tomb);

            // Legkisebb elem megkeresése
            Legkisebb(tomb, out minSzam, out minX, out minY);

            // Legnagyobb elem megkeresése
            Legnagyobb(tomb, out maxSzam, out maxX, out maxY);

            // Eredmény kiírása
            Kiir(minSzam, minX, minY, maxSzam, maxX, maxY, tomb.GetLength(0), tomb.GetLength(1));
        }

        private static void Kiir(int minSzam, int minX, int minY, int maxSzam, int maxX, int maxY, int sorok, int oszlopok)
        {
            Console.WriteLine($"A tömb adatai:\n - sorok száma: {sorok}\n - oszlopok száma: {oszlopok}\n - elemek száma: {sorok * oszlopok}\n - legkisebb elem értéke: {minSzam}, helye: [{minX}, {minY}]\n - legnagyobb elem értéke: {maxSzam}, helye: [{maxX}, {maxY}]");

            Console.ReadKey();
        }

        private static void Legnagyobb(int[,] ptomb, out int pmaxSzam, out int pmaxX, out int pmaxY)
        {
            // Változók
            pmaxSzam = int.MinValue; // A legkisebb egész számmal indulok, hogy a mátrix bármely értéke nagyobb legyen nála
            pmaxX = pmaxY = 0;

            // Sorok ciklusa
            for (int i = 0; i < ptomb.GetLength(0); i++)
            {
                // Oszlopok ciklusa
                for (int j = 0; j < ptomb.GetLength(1); j++)
                {
                    if (ptomb[i, j] > pmaxSzam)
                    {
                        pmaxSzam = ptomb[i, j];
                        pmaxX = i;
                        pmaxY = j;
                    }
                }
            }
        }

        private static void Legkisebb(int[,] ptomb, out int pminSzam, out int pminX, out int pminY)
        {
            // Változók
            pminSzam = int.MaxValue; // A legnagyobb egész számmal indulok, hogy a mátrix bármely értéke kisebb legyen nála
            pminX = pminY = 0;

            // Sorok ciklusa
            for (int i = 0; i < ptomb.GetLength(0); i++)
            {
                // Oszlopok ciklusa
                for (int j = 0; j < ptomb.GetLength(1); j++)
                {
                    if (ptomb[i,j] < pminSzam)
                    {
                        pminSzam = ptomb[i, j];
                        pminX = i;
                        pminY = j;
                    }
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
                    ptomb[i, j] = rnd.Next(-1000,1001);
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
                catch (FormatException e) 
                {
                    Console.WriteLine("Nem számot adott meg!");
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
