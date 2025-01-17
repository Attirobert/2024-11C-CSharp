using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* A projekt a tömbök elemi kezelését mutatja be. 
 
 */

namespace Tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb1,
                tomb2 = { 1, 2, 3, 4 };

            // Feltöltjük a tomb1-et
            tomb1 = new int[15];

            for (int i = 0; i < 10; i++)
            {
                tomb1[i] = i;
            }
            Console.WriteLine($"A tömbök méretei a deklaráció után: \ntomb1: {tomb1.Length}\ntomb2: {tomb2.Length}");
        }
    }
}
