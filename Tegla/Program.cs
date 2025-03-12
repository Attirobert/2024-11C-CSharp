using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tegla
{ //Beolvassunk 3 egész számot, amelyek a téglatest oldalai, majd kiszámoljuk a téglatest felszínét, térgoatát, majd kiiratjuk az eredményt
    internal class Program
    {
        static void Main(string[] args)
        {
            //Változók
            int a,
                b,
                c,
                terfogat,
                felszin;

            //Bekérés
            a = Bekeres("Bekérjük az A-t");
            b = Bekeres("Bekérjük a B-t");
            c = Bekeres("Bekérjük a C-t");

            //Kiszámitás
            terfogat = Terfogat(a ,b, c);
            felszin = Felszin(a, b, c);

            //Kiiras
            Kiiras(terfogat, felszin);




        }

        private static void Kiiras(int terfogat, int felszin)
        {
            Console.WriteLine($"A téglatest felszine: {felszin}, a térfogata: {terfogat}");
            Console.ReadKey();
        }

        private static int Felszin(int a, int b, int c)
        {
            int y = 2*(a * b + a * c + b * c);
            return y;
        }

        private static int Terfogat(int a, int b, int c)
        {
            int y = a * b * c;
            return y;
        }

        private static int Bekeres(string v)
        {
            int x = 0;
            Console.WriteLine(v);
            x=Convert.ToInt32(Console.ReadLine());
            
            return x;
        }
    }
}
