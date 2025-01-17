using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Bekérünk öt számot és a végén a legnagyobbat kiírjuk
 */
namespace ForCiklus
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0,
                maxSzam = int.MinValue;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Adjon meg egy egész számot!");
                szam = Convert.ToInt32(Console.ReadLine());

                if (szam > maxSzam) szam = maxSzam;
            }

            Console.WriteLine($"A legnagyobb szám: {maxSzam}");
            Console.WriteLine("Köszönöm a játékot!");
            Console.ReadKey();
        }
    }
}
