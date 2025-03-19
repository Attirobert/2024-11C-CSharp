using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Beolvasunk két egész számot a konzolról
 * Kiszámítjuk a két szám hányadosát
 * Az eredményt kiíratjuk a konzolra
 * A feladat lényege a kivételkezelés bemutatása
 */

namespace Kivetel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Változók
            int osztando = 0,
                oszto = 0;
            double eredmeny = 0;

            // Beolvasások
            osztando = Beolvas("Adja meg az osztandót!");

            oszto = Beolvas("Adja meg az osztót!");

            // Kiszámítjuk az eredményt
            eredmeny = szamitas(osztando, oszto);

            // Kiírjuk az eredményt
            Kiir(eredmeny);
        }

        private static void Kiir(double ered)
        {
            Console.WriteLine($"Az osztás eredménye: {ered}");
            Console.ReadKey();
        }

        private static double szamitas(int osztando, int oszto)
        {
            double x = 0;
            try
            {
                x = (osztando / oszto);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nullával akart osztani!");
                oszto = 1;  // Nem csak hibaüzenetet írathatunk ki, hanem műveleteket végezhetünk!
            }
            return x;
        }

        private static int Beolvas(string v)
        {
            int x = 0;
            try
            {   // Minden olyan műveletet, ami hibát okozhat, try - catch blokkba kell foglalni!
                Console.WriteLine(v);
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)   // Ha ismerjük a kivétel osztályát, akkor célzottan kiszűrjük
            {
                Console.WriteLine("Nem számot adott meg!");
            }
            catch (Exception e) // Ha nem ismerjük a kivétel osztályát, akkor az ősosztállyal kezeljük le.
            {
                Console.WriteLine($"Valami hiba történt! {e.ToString()};");
            }
            return x;
        }
    }
}
