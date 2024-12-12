using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Kérjünk be egy számot és írjuk ki, hogy prímszám-e!
 */

namespace Primszam
{
    internal class PrimszamProg
    {
        static void Main(string[] args)
        {
            int szam,
                oszto;

            bool prim = true;

            string msg;

            Console.WriteLine("Adjon meg egy egész számot!");
            szam = Convert.ToInt32(Console.ReadLine());

            oszto = szam / 2;

            while (oszto > 3 && prim)
            {
                if (szam % oszto == 0) prim = false;
                oszto--;
            }

            msg = prim ? "prím" : "nem prím";

            Console.WriteLine($"A {szam} {msg}szám.");

            Console.ReadKey();
        }
    }
}
