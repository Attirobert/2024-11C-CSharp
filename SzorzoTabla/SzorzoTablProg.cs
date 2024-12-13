using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzorzoTabla
{
    class SzorzoTablProg
    {
        static void Main(string[] args)
        {
            // Változók
            int szam = 5,
                alsoHatar = 1,
                felsoHatar = 10;

            // Ciklus
            for (int i = alsoHatar; i <= felsoHatar; i++)
            {
                Console.WriteLine($"{szam} * {i} = {szam * i}");
            }

            Console.ReadKey();
        }
    }
}
