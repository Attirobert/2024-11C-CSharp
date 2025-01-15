using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Készítsünk programot, mely a következő feladatokat végzi el!
Bekéri a felhasználó nevét, valamint születésének évét. Kiszámítja a felhasználó életkorát. Ezután egy üres képernyőn, melynek kék a háttere, a képernyő közepén megjeleníti sárga színnel a felhasználó nevét, majd alatta piros színnel a felhasználó életkorát.
*/
namespace Eletkor
{
    class EletkorProg
    {
        static void Main(string[] args)
        {
            // Változók megadása
            string nev; // Ebben tároljuk a nevet
            int eletkor,    // A kiszámított életkor
                szuletesiEv = 2000,    // Születés éve
                legkorabbiEv = 2000;    // Legkorábbi születési év
            bool ujra = true;
            
            // Adatok bekérése
            Console.WriteLine("Add meg a neved: ");
            nev = Console.ReadLine();
            Console.WriteLine("Add meg a születésed évét: ");

            while (ujra)
            {
                ujra = !(int.TryParse(Console.ReadLine(), out szuletesiEv) && szuletesiEv >= legkorabbiEv);
                if (ujra) Console.WriteLine("Hibás évszám\nAdd meg újra: ");
            }
            // Életkor kiszámítása
            // A DateTime egy statikus osztály, amely a következő tulajdonságokkal rendelkezik:
            //  Now - Rendszerdátum
            //  Now.Year - A rendszerdátumból az évszám
            eletkor = DateTime.Now.Year - szuletesiEv;

            // Színek beállítása
            Console.Clear();    // Képernyő törlése
            Console.BackgroundColor = ConsoleColor.Blue;    // Háttér színe

            // Név kiírása
            Console.ForegroundColor = ConsoleColor.Yellow;  // Név betűjének színe
            Console.WriteLine(nev);
            
            
            // Életkor kiírása
            Console.ForegroundColor = ConsoleColor.Red; // Életkor színe
            Console.WriteLine($"Életkor: {eletkor}");
            
            Console.ReadKey();
        }
    }
}
