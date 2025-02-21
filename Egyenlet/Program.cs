using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Projekt név: Egyenlet
 * Kérje be egy másodfokú egyenlet [-5; 5] tartományba eső együtthatóit és számolja ki a függvény értékeit a x = [-6;6] értékekre! Használjon metódusokat a műveletekhez!
 */

namespace Egyenlet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Változók deklarációja
            int a = 0, b = 0, c = 0,    // Együtthatók
                x = 0,  // Függő változó
                y2 = 0,
                y1 = 0;  // Fv érték


            // Az "a" együttható bekérése
            a = Beolvas("Adja meg az 'a' együttható értékét!");

            // A "b" együttható bekérése
            b = Beolvas("Adja meg az 'b' együttható értékét");

            // A "c" együttható bekérése
            c = Beolvas("Adja meg az 'c' együttható értékét");

            // Az "x" érték meghatározása
            x = fuggo();

            // A függvény értékének kiszámítása
            y1 = szamitas(a, b, c, true);
            y2 = szamitas(a, b, c, false);

            // Kiírom a függvény értékét
            Kiir(y1, y2);
        }

        private static void Kiir(int y1, int y2)
        {
            Console.WriteLine($"Az egyenlet első megoldása {y1}");
            Console.WriteLine($"Az egyenlet második megoldása {y2}");

            Console.ReadKey();
        }

        private static int szamitas(int a, int b, int c, bool plus)
        {
            // Plus változó true, ha az 1. értéket számíttatom ki, egyébként false
            int d1 = (int)Math.Pow(b * b - 4*a*c, 2);
            int ered1 = (-b + d1) / 2 * a;
            int ered2 = (-b - d1) / 2 * a;

            return (plus) ? ered1 : ered2;
        }

        private static int fuggo()
        {
            Random rnd = new Random();

            return rnd.Next(-6, 6);
        }

        private static int Beolvas(string v)
        {
            Console.WriteLine(v);

            int y = Convert.ToInt32(Console.ReadLine());
            return y;
        }
    }
}
