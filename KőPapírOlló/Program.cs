using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * A klasszikus játék megvalósítása.
 * A játék addig folytatódik, amíg a játékos "n" jelet ír be.
 * A játékos választását véletlenszám generátorral állítjuk elő.
 * Tartsa nyílván a játék állását, amit minden forduló után kiír.
 */
namespace KőPapírOlló
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók
            Random r = new Random();    // Random objektum 

            string compVálasztása = "",
                játékosVálasztása = "";

            int compPontjai = 0,
                játékosPontjai = 0;

            do
            {
                // A játékos választása
                Console.WriteLine("Válassz! (k/p/o)");

                switch (Console.ReadKey().KeyChar)
                {
                    case 'k': játékosVálasztása = "kő"; break;
                    case 'p': játékosVálasztása = "papír"; break;
                    case 'o': játékosVálasztása = "olló"; break;
                    default:
                        Console.WriteLine("Hibás válasz!");
                        continue;   // Hibás válasz esetén újra kezdi a ciklust
                }

                // A gép választása
                switch (r.Next(0,3)
                {
                    case 0: compVálasztása = "kő"; break;
                    case 1: compVálasztása = "papír"; break;
                    case 2: compVálasztása = "olló"; break;
                }

                // A játék kiértékelése
                if (    // A gép nyerései
                    (játékosVálasztása == "kő" && compVálasztása == "papír")
                    || (játékosVálasztása == "papír" && compVálasztása == "olló")
                    || (játékosVálasztása == "olló" && compVálasztása == "kő")
                    )
                {
                    Console.WriteLine($"A gép nyert! A játék állása:\nSzámítógép: {++compPontjai},\nTe: {játékosPontjai}");
                }
                else if (játékosVálasztása == compVálasztása)   // Döntetlen
                {
                    Console.WriteLine($"Döntetlen! A játék állása:\nSzámítógép: {compPontjai},\nTe: {játékosPontjai}");
                }
                else
                {   // A játékos nyert
                    Console.WriteLine($"A játékos nyert! A játék állása:\nSzámítógép: {compPontjai},\nTe: {++játékosPontjai}");
                }

                // Játék folytatása vagy befejezése
                Console.WriteLine("Akarsz még játszani? i/n");

                // A Console.ReadKey() ConsoleKeyInfo objektumot ad vissza, amelyben a KeyChar tulajdonság tartalmazza a leütött karaktert.
                // A true paraméter hatására nem jelenik meg a képernyőn a leütött karakter
            } while (Console.ReadKey(true).KeyChar == 'n');
        }
    }
}
