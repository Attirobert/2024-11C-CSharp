using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Bekérünk egy egész számot és kiírjuk, ha pozitív
 */
namespace Kor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változó
            int szam = 0;
            string msgP = "A szám pozitív!";
            string msgN = "A szám nem pozitív!";

            Console.WriteLine("Adjon meg egy egész számot!");
            szam = Convert.ToInt32(Console.ReadLine());

            if (szam > 0)
            {
                Console.WriteLine(msgP);
            }
            else
            {
                Console.WriteLine(msgN);
            }

            Console.ReadKey();

        }
    }
}
