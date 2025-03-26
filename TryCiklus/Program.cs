using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCiklus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Változók
            int szam,
            negyzet = 0;

            //Beolvasás
            szam = Beolvas("Adjon meg egy számot:");

            //Négyzetreemelés
            negyzet = szamitas(szam);

            //Kiiras
            Kiiras(negyzet);
        }
        private static int szamitas(int szam)
        {
            int i = szam + szam;
            return i;
        }

        private static void Kiiras(int negyzet)
        {
            Console.WriteLine($"A megoldás {negyzet}");
            Console.ReadKey();
        }
        private static int Beolvas(string s)
        {
            Console.WriteLine(s);
            int y = 0;
            string x;
            bool ujra = true;
            do
            {
                x = Console.ReadLine();
                try
                {
                    y = Convert.ToInt32(x);
                    ujra = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Hibáztál ÖREG! \n Add meg újra a számot");
                }
            }
            while (ujra);
            return y;
        }
    }
}
