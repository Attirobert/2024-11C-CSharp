using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Változó
            string s = "A C# kiváló programozási nyelv";

            for (int i = 0; i < 5; i++)
            {
                char x =Kivalaszt(s);
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }

        private static char Kivalaszt(string s)
        {
            Random rnd = new Random();
            int i = rnd.Next(0, s.Length);
            return s[i];
        }
    }
}
