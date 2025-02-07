using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Adott két tömb, amelyeknek a méretét a felhasználótól kérjük be.
 * A két tömböt feltöltjük véletlen egész számokkal a [-100,+100] tartományból.
 * Ezután a két tömb tartalmát szétválogatjuk két másik tömbbe, úgy, hogy az iegyik tömbbe a negatív, a másikba a pozitív számok kerülnek.
 * Végül kiíratjuk mind a négy tömböt.
 */
namespace Tombs
{
    class Tombs
    {
        static void Main(string[] args)
        {
            //Valtozok
            int inpTomb1, //Az 1-es tömbnek a mérete
                inpTomb2,   // A 2-es tömb mérete
                j,
                k;
            int[] vszTomb1,
                vszTomb2,
                pozTomb,    // Pozitív számok tömbje
                negTomb;    // Negatív számok tömbje

            //Olvassuk be a tömbök méretét mert kell:)
            inpTomb1 = szamBeolvasas("Add meg az első tömb méretét");
            inpTomb2 = szamBeolvasas("Add meg a második tömb méretét");

            //Tömbök létrehozása mert kell :(
            vszTomb1 = new int[inpTomb1];
            vszTomb2 = new int[inpTomb2];
            pozTomb = new int[inpTomb1+inpTomb2];
            negTomb = new int[inpTomb1 + inpTomb2]; 

            //Feltöltjuk a tömböket
            tombFeltoltes(vszTomb1);    // 1. tömb
            tombFeltoltes(vszTomb2);    // 2. tömb

            // Szétválogatjuk a tömböket
            szetValogatas(vszTomb1, pozTomb, negTomb);
            szetValogatas(vszTomb2, pozTomb, negTomb);

            // Kiíratjuk a tömböket
            kiir("A vsz1 tömb:", vszTomb1);
            kiir("\nA vsz2 tömb:", vszTomb2);
            kiir("\nA pozitív tömb:", pozTomb);
            kiir("\nA negatív tömb:", negTomb);

            Console.ReadKey();
        }

        static void kiir(string v, int[] t)
        {
            Console.WriteLine(v);
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write($"{t[i]}, ");
            }
        }

        static int szamBeolvasas(string s)
        {
            Console.WriteLine(s);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void tombFeltoltes(int[] t)
        {
            Random rnd = new Random();

            for (int x = 0; x < t.Length; x++)
            {
                t[x] = rnd.Next(-100, 101);
            }
        }

        static void szetValogatas(int[] t, int[] pozTomb, int[] negTomb)
        {
            int j = 0;  // pozTomb indexe
            int k = 0;  // negTomb indexe
            for (int i = 0; i < t.Length; i++)
            {
                // Megnézzük, hogy a milyen elem van ebben 
                if (t[i] > 0)
                {
                    pozTomb[j] = t[i];
                    j++;    // A j indexet növeljük, mert a "j" indexű elemet feltöltöttük
                }
                else
                {
                    negTomb[k] = t[i];
                    k++;
                }
            }
        }
    }
}
