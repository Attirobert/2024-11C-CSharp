using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Bekérjük a hatvány alapot és kitevőt.
 * Kiírjuk a hatvány értékét, majd ebből kiszámoljuk a négyzetgyökét és kiírjuk 2 tizedes pontossággal
 */
namespace Hatvany
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók
            double alap = 0,
                kitevo = 0,
                hatvany = 0;
            double ngyok = 0.0;

            Console.WriteLine("Adja meg a hatvány alapját! \nCsak egész szám lehet!");
            alap = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adja meg a hatvány kitevőt! \nCsak egész szám lehet!");
            kitevo = int.Parse(Console.ReadLine());

            //hatvany = Math.Pow(alap, kitevo);
            //ngyok = Math.Sqrt(hatvany);

            //Console.WriteLine($"A {alap} szám {kitevo}-dik hatványa: {hatvany},\nennek a négyzetgyöke: {ngyok: 0.00}");
            Console.WriteLine($"A {alap} szám {kitevo}-dik hatványa: {Math.Pow(alap, kitevo)},\nennek a négyzetgyöke: {Math.Sqrt(hatvany): 0.00}");

            Console.ReadKey();
        }
    }
}
