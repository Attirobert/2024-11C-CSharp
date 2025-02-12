using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Számolja ki egy henger felszínét és térfogatát, majd írja ki a képernyőre 3 tizedes pontossággal! Az adatokat eljárásban számítsa ki!
 * */

namespace Henger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Osztályváltozók
            int sugar,
                magas;
            double felszin,
                terfogat;

            // 1. henger
            // Sugár beolvasása
            sugar = Beolvas("Adja meg a sugarat!");

            // Magasság beolvasása
            magas = Beolvas("Adja meg a magasságot!");

            // Felszín kiszámítása
            felszin = Felszin(sugar, magas);

            // Térfogat kiszámítása
            terfogat = Terfogat(sugar, magas);

            // Eredmény kiíratása
            Kiir(felszin, terfogat);
        }

        // Felszín számítási metódus
        static private double Felszin(int r, int m)
        {
            return 2 * r * Math.PI * m;
        }

        // Térfogat számítási metódus
        static private double Terfogat(int r, int m)
        {
            return r * r * Math.PI * m;
        }

        // Beolvasási metódus
        static private int Beolvas(string s)
        {
            Console.WriteLine(s);
            return int.Parse(Console.ReadLine());
        }

        // Kiírási metódus
        static private void Kiir(double f, double t)
        {
            Console.WriteLine($"A henger felszíne: {f}, \ntérfogata: {t}");
            Console.ReadKey();
        }
    }
}
