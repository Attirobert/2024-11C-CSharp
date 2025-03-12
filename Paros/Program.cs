using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paros
{ //Beolvasunk konzolról egy számot, és eldöntjük, hogy páros-e vagy páratlan-e.
    internal class Program
    {
        static void Main(string[] args)
        {
            //Változók
            int p;
            bool paros = false;

            //Beolvassuk
            p = beolvas("Adjuk meg a számot. ");
            
            // Eldöntjük, hogy páros-e
            paros = dontes(p);

            // Kiíratás
            kiir(paros);
        }

        private static void kiir(bool paros)
        {
            if (paros)
                Console.WriteLine($"A szám páros");
            else
                Console.WriteLine("A szám páratlan");

            Console.ReadKey();
        }

        private static bool dontes(int p)
        {
            if (p % 2 == 0)
                return true;
            else return false;
        }

        private static int beolvas(string v)
        {
            Console.WriteLine(v);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
