using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Adott két tömb, amelyeknek a méretét a felhasználótól kérjük be.
 * A két tömböt feltöltjük véletlen egész számokkal a [-100,+100] tartományból.
 * Ezután a két tömb tartalmát szétválogatjuk két másik tömbbe, úgy, hogy az egyik tömbbe a negatív, a másikba a pozitív számok kerülnek.
 * Végül kiíratjuk mind a négy tömböt.
 */
namespace Tombs
{
    class Tombs
    {
        static void Main(string[] args)
        {
            //Valtozok mert kell
            int tomb1, //Az 1-es tömbnek a mérete
                tomb2,
                j,
                k;
            int[] vsz,
                vsz1,
                vsz2,
                vsz3;
            Random rnd = new Random();

            //Olvassuk be a tömbök méretét mert kell:)

            Console.WriteLine("Add meg az első tömb méretét");
            tomb1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a második tömb méretét");
            tomb2 = Convert.ToInt32(Console.ReadLine());

            //Tömbök létrehozása mert kell :(

            vsz = new int[tomb1];
            vsz1 = new int[tomb2];
            vsz2 = new int[tomb1+tomb2];    // Pozitív tömb
            vsz3 = new int[tomb1 + tomb2];  // Negatív tömb

            //feltoltjuk az elso tombot mert megjott az osztondij :D
            for (int x = 0; x < vsz.Length; x++)
            {
                vsz[x] = rnd.Next(-100, 101);
            }

            //feltoltjuk a második tombot
            for (int x = 0; x < vsz1.Length; x++)
            {
                vsz1[x] = rnd.Next(-100, 101);
            }

            // Szétválogatjuk a számokat
            // A vsz tömböt válogatjuk
            j = 0;  // vsz2 indexe
            k = 0;  // vsz3 indexe
            for (int i = 0; i < vsz.Length; i++)
            {
                // Megnézzük, hogy a milyen elem van ebben 
                if (vsz[i] > 0)
                {
                    vsz2[j] = vsz[i];
                    j++;    // A j indexet növeljük, mert a "j" indexű elemet feltöltöttük
                }
                else
                {
                    vsz3[k] = vsz[i];
                    k++;
                }
            }

            // A vsz1 tömböt válogatjuk
            j = 0;  // vsz2 indexe
            k = 0;  // vsz3 indexe
            for (int i = 0; i < vsz1.Length; i++)
            {
                // Megnézzük, hogy a milyen elem van ebben 
                if (vsz1[i] > 0)
                {
                    vsz2[j] = vsz1[i];
                    j++;    // A j indexet növeljük, mert a "j" indexű elemet feltöltöttük
                }
                else
                {
                    vsz3[k] = vsz1[i];
                    k++;
                }
            }

            // Kiíratjuk a vsz tömböt
            Console.WriteLine("A vsz tömb:");
            for (int i = 0; i < vsz.Length; i++)
            {
                Console.Write($"{vsz[i]}, ");
            }

            // Kiíratjuk a vsz1 tömböt
            Console.WriteLine("\nA vsz1 tömb:");
            for (int i = 0; i < vsz1.Length; i++)
            {
                Console.Write($"{vsz1[i]}, ");
            }

            // Kiíratjuk a vsz2 tömböt
            Console.WriteLine("\nA vsz tömb:");
            for (int i = 0; i < vsz2.Length; i++)
            {
                Console.Write($"{vsz2[i]}, ");
            }

            // Kiíratjuk a vsz3 tömböt
            Console.WriteLine("\nA vsz tömb:");
            for (int i = 0; i < vsz3.Length; i++)
            {
                Console.Write($"{vsz3[i]}, ");
            }

            Console.ReadKey();
        }
    }
}
