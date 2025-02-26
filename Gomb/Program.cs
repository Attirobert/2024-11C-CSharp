using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Kérjen be konzolról egy valós számot, ez lesz egy gömb sugara.
 * Számolja ki a gömb felszínét és térfogatát!
 * A kiszámított adatokat írassa ki!
 * A megoldásban használjon metódusokat!
 * A = 4 * r2 * PI
 * V = (4 * r3 * PI) / 3
 */

namespace Gomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Változók deklarálása
            double r,
                felszin,
                terfogat;

            //Beolvassuk a sugarat
            r = Beolv();

            //Kiszámítjuk a felszínt
            felszin = felsz(r);

            //Kiszámítjuk a térfogatot
            terfogat = terf(r);

            //Kiiratjuk az eredményt
            Kiir(felszin, terfogat);
        }

        private static void Kiir(double felszin, double terfogat)
        {
            Console.WriteLine($"A gömb felszíne: {felszin}, és a térfogata: {terfogat}");
            Console.ReadKey();
        }

        private static double terf(double r)
        {
            //V = (4 * r3 * PI) / 3
            return (4*r*r*r*Math.PI) / 3;
            //return (felsz(r)*r)/3
        }

        private static double felsz(double r)
        {
            //A = 4 * r2 * PI
            return 4 * r * r * Math.PI;
 
        }

        private static double Beolv()
        {
            Console.WriteLine("Adja meg a sugarat: \n");
            return double.Parse(Console.ReadLine());
        }
    }
}
