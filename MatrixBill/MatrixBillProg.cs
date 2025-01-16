using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Billentyűzetről kell beolvasni a mátrix elemeit, amelyek egész számok lehetnek.  Először kérje be a sorok és oszlopok számát.  Ezután olvassa be az elmeket.  Minden beolvasásnál vigyázzon arra, hogy csak egész számokat lehessen megadni.
Amikor megfelelő számú elemet beolvasott, fejezze be a beolvasást.
Külön metódussal írassa ki konzolra a mátrixot (sor - oszlop formában).
*/

namespace MatrixBill
{
    internal class MatrixBillProg
    {
        static void Main(string[] args)
        {
            // Változók
            int sorok,          // A felhasználó által megadott sorok száma
                oszlopok,       // A felhasználó által megadott oszlopok szám
                maxSor = 10,    // A sorok megadható maximális száma
                maxOszlop = 10, // Az oszlopok megadható maximális száma
                adat;           // A beolvasott adat

            int[,] matrix;       // Deklaráljuk a mátrixot

            // Beolvassuk a sorok számát
            Console.WriteLine($"Adja meg a mátrix sorainak számát! (max {maxSor} lehet!");
            while(!(int.TryParse( Console.ReadLine(), out sorok) && sorok > 0 && sorok <= maxSor ))
            {
                    Console.WriteLine("Hibás adat, ismételje meg!");
            }

            // Beolvassuk az oszlopok számát
            Console.WriteLine($"Adja meg a mátrix oszlopainak számát! (max {maxOszlop} lehet!");
            while(!(int.TryParse( Console.ReadLine(), out oszlopok) && oszlopok > 0 && oszlopok <= maxOszlop))
            {
                    Console.WriteLine("Hibás adat, ismételje meg!");
            }

            // Létre hozzuk a mátrixot
            matrix = new int[sorok, oszlopok];

            // Beolvassuk az adatokat.  Soronként és azon belül oszloponként haladunk
            // Egy mátrix első (0.) indexének méretét (hosszát) a GetLength(0) metódussal kapom meg.
            // ennek megfelelően a második (1.) indexének méretét (hosszát) a GetLength(1) metódussal kapom meg - és így tovább...
            for (int i = 0; i < matrix.GetLength(0); i++)   // Sorok ciklusa
            { 

                Console.WriteLine($"A(z) {i}. sor adatait kérem:");
                for (int j = 0; j < matrix.GetLength(1); j++) // Oszlopok ciklusa
                {

                    while (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
                    {
                        Console.WriteLine("Hibás adat, ismételje meg!");
                    }
                }
            }

            // Kiíratás
            Kiiratas(matrix);

            Console.ReadKey();  // Megállítjuk a képernyőt
        }

        private static void Kiiratas(int[,] matrix)
        {

            // Kiírjuk az adatokat.  Soronként és azon belül oszloponként haladunk
            for (int i = 0; i < matrix.GetLength(0); i++)   // Sorok ciklusa
            {
                Console.WriteLine();    // Új sort kezdünk
                for (int j = 0; j < matrix.GetLength(1); j++) // Oszlopok ciklusa
                {

                    Console.Write(matrix[i,j]);
                    if (j < matrix.GetLength(1)-1) Console.Write(", ");   // Az elemek közé vesszőt teszünk, kivéve az utolsó elemet
                }

                Console.Write(";"); // A sor végére pontosvesszőt teszünk

            }
        }
    }
}
