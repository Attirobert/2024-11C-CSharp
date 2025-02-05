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
            //Valtozok mert kell
            int inpTomb1, //Az 1-es tömbnek a mérete
                inpTomb2,   // A 2-es tömb mérete
                j,
                k;
            int[] vszTomb1,
                vszTomb2,
                pozTomb,
                negTomb;

            //Olvassuk be a tömbök méretét mert kell:)

            inpTomb1 = szamBeolvasas("Add meg az első tömb méretét");
            inpTomb2 = szamBeolvasas("Add meg a második tömb méretét");

            //Tömbök létrehozása mert kell :(
            vszTomb1 = new int[inpTomb1];
            vszTomb2 = new int[inpTomb2];
            pozTomb = new int[inpTomb1+inpTomb2];    // Pozitív tömb
            negTomb = new int[inpTomb1 + inpTomb2];  // Negatív tömb

            //feltoltjuk az elso tombot mert megjott az osztondij :D
            for (int x = 0; x < vszTomb1.Length; x++)
            {
                vszTomb1[x] = rnd.Next(-100, 101);
            }

            //feltoltjuk a második tombot
            for (int x = 0; x < vszTomb2.Length; x++)
            {
                vszTomb2[x] = rnd.Next(-100, 101);
            }

            // Szétválogatjuk a számokat
            // A vszTomb1 tömböt válogatjuk
            j = 0;  // pozTomb indexe
            k = 0;  // negTomb indexe
            for (int i = 0; i < vszTomb1.Length; i++)
            {
                // Megnézzük, hogy a milyen elem van ebben 
                if (vszTomb1[i] > 0)
                {
                    pozTomb[j] = vszTomb1[i];
                    j++;    // A j indexet növeljük, mert a "j" indexű elemet feltöltöttük
                }
                else
                {
                    negTomb[k] = vszTomb1[i];
                    k++;
                }
            }

            // A vszTomb2 tömböt válogatjuk
            j = 0;  // pozTomb indexe
            k = 0;  // negTomb indexe
            for (int i = 0; i < vszTomb2.Length; i++)
            {
                // Megnézzük, hogy a milyen elem van ebben 
                if (vszTomb2[i] > 0)
                {
                    pozTomb[j] = vszTomb2[i];
                    j++;    // A j indexet növeljük, mert a "j" indexű elemet feltöltöttük
                }
                else
                {
                    negTomb[k] = vszTomb2[i];
                    k++;
                }
            }

            // Kiíratjuk a vszTomb1 tömböt
            Console.WriteLine("A vsz tömb:");
            for (int i = 0; i < vszTomb1.Length; i++)
            {
                Console.Write($"{vszTomb1[i]}, ");
            }

            // Kiíratjuk a vszTomb2 tömböt
            Console.WriteLine("\nA vsz1 tömb:");
            for (int i = 0; i < vszTomb2.Length; i++)
            {
                Console.Write($"{vszTomb2[i]}, ");
            }

            // Kiíratjuk a pozTomb tömböt
            Console.WriteLine("\nA vsz tömb:");
            for (int i = 0; i < pozTomb.Length; i++)
            {
                Console.Write($"{pozTomb[i]}, ");
            }

            // Kiíratjuk a negTomb tömböt
            Console.WriteLine("\nA vsz tömb:");
            for (int i = 0; i < negTomb.Length; i++)
            {
                Console.Write($"{negTomb[i]}, ");
            }

            Console.ReadKey();
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
    }
}
