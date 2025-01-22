using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Ez a példa a switch működését demonstrálja
 * Beolvasunk egy természetes számot [1,12] tartományból és kiírjuk, hogy melyik hónap neve tartozik hozzá.
 * */

namespace Switch
{
    class SwitchProg
    {
        static void Main(string[] args)
        {
            // Változók
            int honapSzam;
            string honapNev;
            string beolv;

            // Beolvasás
            Console.WriteLine("Adj meg egy egész számot");
            beolv=Console.ReadLine();
            honapSzam = Convert.ToInt32(beolv);
            if (1 <= honapSzam && honapSzam <= 12)
            {
                switch (honapSzam)
                {
                    case 1:
                        Console.WriteLine("Január");
                        break;
                    case 2:
                        Console.WriteLine("Februar");
                        break;
                    case 3:
                        Console.WriteLine("Marcius");
                        break;
                    case 4:
                        Console.WriteLine("Aprilis");
                        break;
                    case 5:
                        Console.WriteLine("Majus");
                        break;
                    case 6:
                        Console.WriteLine("Junius");
                        break;
                    case 7:
                        Console.WriteLine("Julius");
                        break;
                    case 8:
                        Console.WriteLine("Augusztus");
                        break;
                    case 9:
                        Console.WriteLine("Szeptember");
                        break;
                    case 10:
                        Console.WriteLine("Oktober");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 12:
                        Console.WriteLine("December");
                        break;

                    default:
                        Console.WriteLine("Hibás az adat");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
