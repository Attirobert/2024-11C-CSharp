using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZartSzelveny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Változók
            int a,
                b,
                terulet,
                terulet2;

            //Bekérés
            a = Beolvas("Add meg az 'A'-t");
            b = Beolvas("Add meg az 'B'-t");

            //Kiszámítás
            terulet = szamitas(a);
            terulet2 = szamitas(b);
            //Kiírás
            kiir(terulet,terulet2);
        }

        private static void kiir(int terulet, int terulet2)
        {
            Console.WriteLine($"A zártszelvény területe {terulet - terulet2}");
            Console.ReadKey();
        }

        private static int szamitas(int a)
        {
            return a * a;
        }

        private static int Beolvas(string v)
        {
            int x = 0;
            Console.WriteLine(v);
            x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
    }
}
