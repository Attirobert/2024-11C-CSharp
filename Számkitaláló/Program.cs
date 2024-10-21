using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * A játék kétszemélyes, a gép és a játékos játszik egymással.  A játékban két szerep van: az egyik, aki választ egy számot 1 és 100 között, a másik tippekkel megpróbálja kitalálni ezt a számot. A kitaláló 5 lépésben tippelhet.  Akkor nyer, ha eltalálta a számot. Nyerni csak a kitaláló nyerhet, a szám választója nem. Egy kitalálási folyamatot játék menetnek nevezünk. Egy játék menet indulásakor a játékos dönti el a gép kérdésére, hogy melyik szerepben akar játszani. A játéknak akkor van vége, ha egy játék menet végén a gépnek a folytatásra vonatkozó kérdésére a játékos nemmel válaszol.
 */
namespace Számkitaláló
{
    internal class Program
    {
        static int MaxTippSzám = 5,
            AlsóHatár = 1,
            FelsőHatár = 100;
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int GépNyer = 0,
                JátékosNyer = 0;
            do
            {
                Console.WriteLine("Válassz játékmódot!");
                Console.WriteLine("1 - Te gondolsz egy számra");
                Console.WriteLine("2 - A gép gondol egy számra");

                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1': GépNyer += GépTippel(rnd.Next(AlsóHatár,FelsőHatár)) ? 1 : 0; break;
                    default: JátékosNyer += JátékosTippel(rnd.Next(AlsóHatár,FelsőHatár)) ? 1 : 0; break;
                }

                Console.WriteLine($"A játék állása eddig:\n  A Gép nyert: {GépNyer}\n  Játékos nyert: {JátékosNyer}");
                Console.WriteLine("Játszunk még (i/n)?");
            } while (Console.ReadKey(true).KeyChar != 'n');
        }

        private static bool JátékosTippel(int szam)
        {
            int tipp = 0;
            string msg = "";

            Console.WriteLine("Gondoltam egy számra, kezdhetjük a játékot!");

            for (int i = 0; i < MaxTippSzám; i++) { 
                Console.WriteLine("Tippelj!");
                tipp = int.Parse(Console.ReadLine());

                if (tipp == szam) return true;
                else if (tipp < szam) msg = "Nagyobb számra gondoltam.";
                else msg = "Kisebb számra gondoltam";

                Console.WriteLine(msg);
            }
            return false;

        }

        private static bool GépTippel(int szam)
        {
            int alsóHatár = AlsóHatár,
                felsőHatár = FelsőHatár,
                tipp =0;

            char válasz;

            Console.WriteLine($"Gondolj egy egész számra {AlsóHatár} és {FelsőHatár} között!\n Kezdhetjük a játékot (i/n)?");
            if (Console.ReadKey(true).KeyChar == 'n') return false;

            for (int i = 0; i < MaxTippSzám; i++)
            {
                tipp = alsóHatár + (felsőHatár - alsóHatár) / 2;
                Console.WriteLine($"\nA tippem: {tipp}");

                Console.WriteLine("\nJól tippeltem?");
                Console.WriteLine("n - Nagyobb számra gondoltam");
                Console.WriteLine("k - Kisebb számra gondoltam");
                Console.WriteLine("e - Eltaláltad!");
                válasz = Console.ReadKey(true).KeyChar;

                switch (válasz)
                {
                    case 'n': alsóHatár = tipp; break;
                    case 'k': felsőHatár = tipp; break;
                    case 'e': return true;
                }

            }

            return false;
        }
    }
}
