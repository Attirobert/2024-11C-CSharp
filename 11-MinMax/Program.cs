using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * A feladat két lépésből áll:
 * 1. Konzolról bekérünk egy egész számot (legyen: N), amely egy egész típusú tömb elemeinek számát jelent.  Ezután létre hozzuk ezt a tömböt és feltöltjük -N és +N közé eső véletlen számokkal.
 * 2. Megkeressük a tömbben a legkisebb és a legnagyobb számot és az indexével együtt kiírjuk.
 */
namespace _11_MinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szám = 0,
                maxÉrték = int.MinValue,
                minÉrték = int.MaxValue,
                maxIndex = 0,
                minIndex = 0;

            int[] tömb;

            Random r = new Random();

            Console.WriteLine("Adj meg egy egész számot!");
            szám = int.Parse(Console.ReadLine());

            tömb = new int[szám];

            for (int i = 0; i < tömb.Length; i++)
            {
                tömb[i] = r.Next(-szám,szám);
            } 

            for (int i = 0; i < tömb.Length; i++)
            {
                if (tömb[i] < minÉrték)
                {
                    minÉrték = tömb[i];
                    minIndex = i;
                }
                else if (tömb[i] > maxÉrték)
                {
                    maxÉrték = tömb[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine($"A {tömb.Length + 1} elemű tömb \nlegkisebb eleme, melynek indexe {minIndex}, értéke: {minÉrték}\nlegnagyobb eleme melynek indexe: {maxIndex}, értéke: {maxÉrték}.");
            Console.ReadKey();
        }
    }
}
