using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Létrehozunk egy 10 elemű tömböt és feltöltjük véletlen számokkal (egész)
 * Kiírjuk a számokat.
 * 
 * */

namespace Tombn01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Változók
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // Deklaráció 1
            int[] ints2;    // Deklaráció 2

            ints2 = new int[10];

            Console.WriteLine(ints2.Length);
            Console.WriteLine(ints.Length);

            TombFeltoltes(ints2);
        }

        private static void TombFeltoltes(int[] ints2)
        {
            throw new NotImplementedException();
        }
    }
}
