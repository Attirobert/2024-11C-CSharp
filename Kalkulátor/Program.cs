using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region A program feladata
/* 
 * A program bekér 
 *  - egy valós számot
 *  - egy műveleti jelet a következők közül: + - * / %
 *  - egy újabb valós számot
 *  Ezután kiírja a művelet eredményét
 *  Ezután megkérdezi, hogy akar-e a kezelő újabb számítást végezni, 
 *      - ha igen, akkor törli a képernyőt és újra kezdi az adatbekérést
 *      - ha nem, akkor törli a képernyőt és kilép a programból
 *      
 */
#endregion Eof A program feladata

namespace Kalkulátor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double szám1 = 0, szám2 = 0, eredmény = double.NaN;
            char művelet;
                
            bool folytatás = true;

            int olvasásSzámláló,
                maxOlvasás = 5;

            do
            {
                olvasásSzámláló = 0;

                Console.WriteLine("Adja meg az első számot!");
                szám1 = double.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine("Adja meg a műveleti jelet (+ - * / %)!");
                    művelet = char.Parse(Console.ReadLine());

                    if (++olvasásSzámláló > maxOlvasás)
                    {
                        Console.WriteLine("Sajnálom, tovább nem próbálkozhat!");
                        Environment.Exit(0);
                    }
                    
                }
                while(művelet != '+' && művelet != '-' && művelet != '*' && művelet != '/' && művelet != '%');

                Console.WriteLine("Adja meg a második számot!");
                szám2 = double.Parse(Console.ReadLine());

                switch (művelet)
                {
                    case '+': eredmény = szám1 + szám2; break;
                    case '-': eredmény = szám1 - szám2; break;
                    case '*': eredmény = szám1 * szám2; break;
                    case '/': eredmény = szám1 / szám2; break;
                    case '%': eredmény = szám1 % szám2; break;
                }

                Console.WriteLine($"A művelet eredménye: {eredmény}");
                Console.WriteLine("Folytatja a számolást (i/n)?");

                folytatás = char.Parse(Console.ReadLine()) == 'i';
                Console.ReadKey();
                Console.Clear();
            } while (folytatás);
        }
    }
}
