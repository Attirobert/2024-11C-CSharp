using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region A program feladata
/* 
 * A program bekér egy 1 és 9 közé eső egész számot.  Leellenőrzi, hogy jó számot kapott-e! 
 * Ezután kiírja a számhoz tartozó szorzótáblát.
 * Ezt mindaddig ismétli, amíg 0-át nem írok be.
 */
#endregion Eof A program feladata
namespace Szorzótábla
{
    class Program
    { 
        static void Main(string[] args)
        {
            #region Megoldás
            // Változók
            int szám = 0;   // Ebbe olvassuk be a számot
            bool folytatás = true; // Ezzel jelzem, hogy folytatható-e a játék

            do
            {
                // Tájékoztató szöveg a kezelőnek
                Console.WriteLine("Adjon meg egy egész számot 1 és 9 között!\nHa be akarja fejezni a játékot, akkor 0-t írjon be!");

                // A beolvasást a feltételbe is írhatom.  Figyelni kell a zárójelezésre!
                if ((szám = int.Parse(Console.ReadLine())) != 0)
                {
                    // Ellenőrzöm, hogy megfelelő-e a szám
                    if (szám >=1 & szám<=9)     // ...ha megfelelő
                    {
                        // Ciklusban kiíratom a szorzótáblát
                        for (int i = 1; i < 9; i++)
                        {
                            Console.WriteLine("{0} x {1} = {2}", i, szám, i * szám);
                        }
                    }
                    else    // ...nem megfelelő
                    {
                        Console.WriteLine("Hibás számot adott meg!");
                    }

                }
                else
                {
                    // Kilépek a programból
                    Console.WriteLine("Köszönöm a játékot");
                    folytatás = false;
                }
                Console.WriteLine("Tovább bármely billentyűvel...");
                Console.ReadKey();
            }while(folytatás);
            #endregion Eof Megoldás
        }
    }
}
