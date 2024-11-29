using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Bekérünk két egész számot és kiírjuk az összegüket
 */
namespace SzamInput
{
    class Program
    {
        // A program belépési pontja
        static void Main(string[] args)
        {
            // Változók
            int szam, 
                szam2;

            string szamBe;

            // Beolvasás
            Console.WriteLine("Add meg az első számot!");
            szamBe = Console.ReadLine();
            szam = Convert.ToInt32(szamBe);

            Console.WriteLine("Add meg az második számot!");
            szamBe = Console.ReadLine();
            szam2 = Convert.ToInt32(szamBe);

            Console.WriteLine("A két szám összege: {0}", szam + szam2);

            Console.ReadKey();
        }
    }
}
