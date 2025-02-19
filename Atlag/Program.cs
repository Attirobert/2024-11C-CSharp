using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Állítson elő 8 egész számot [0; 100] tartományban, és írja ki őket egy sorban! Számolja ki a a számok átlagát 2 tizedes pontossággal és írassa ki!.  Minden műveletet metódusokkal végezzen el!
 */

namespace Atlag
{
    internal class Program
    {
        // Változók
        static double[] tomb = new double[8];

        // Tömb feltöltés
        static void Feltolt(double[] tomb)
        {
            Random rnd = new Random();

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.NextDouble() * 100;
            }
        }
        static void Main(string[] args)
        {
            // Feltöltjük a tömböt
            Feltolt(tomb);

            // Kiírjuk a tömböt
            Kiir(tomb);

            // Kiszámítjuk a számok átlagát
            double atlag = Atlag(tomb);

            // Kiíratjuk az átlagot
            KiirAtlag(atlag);

            Console.ReadKey();
        }

        private static void KiirAtlag(double atlag)
        {
            Console.WriteLine($"\n\nA számok átlaga: {atlag}");
        }

        private static double Atlag(double[] tomb)
        {
            double osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
                osszeg += tomb[i];

            return Math.Round(osszeg / tomb.Length, 2);
        }

        private static void Kiir(double[] tomb)
        {
            for (int i = 0;i < tomb.Length -1; i++)
                Console.Write($"{tomb[i]}, ");

            Console.Write($"{tomb[tomb.Length - 1]}; ");
        }
    }
}
