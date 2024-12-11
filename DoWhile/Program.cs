using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;

            do
            {
                Console.WriteLine("Adjon meg egy egész számot!");
                szam = Convert.ToInt32(Console.ReadLine());
                if (szam > 0) Console.WriteLine(" A szám pozitív.");
                else Console.WriteLine("A szám nem pozitív.");

            } while (szam != 0);

            Console.WriteLine("Köszönöm a játékot!");
            Console.ReadKey();

        }
    }
}
