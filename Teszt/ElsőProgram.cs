﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Bekérünk számokat a konzolról addig, amíg az összegük kisebb mint 100
 */
namespace Teszt
{
    class ElsőProgram
    {
        static void Main(string[] args)
        {
            int szam = 0;   // Ebbe olvasom be a számot
            int összeg = 0; // Ebbe gyüjtöm az összeget


            do
            {
                // Üzenet a használónak
                Console.WriteLine("Írjon be egy egész számot!");
                szam = Convert.ToInt32(Console.ReadLine());

                összeg += szam;
            } while (összeg < 100);
            // 
            Console.WriteLine("Köszönöm a játékot!");
            Console.ReadKey();
        }
    }
}
