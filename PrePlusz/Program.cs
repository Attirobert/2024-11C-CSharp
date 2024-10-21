using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Annak bemutatása, hogy mi a különbség a műveleti jel változó előtti és utáni használatában
 * */
namespace PrePlusz
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100,
                y = 11;

            Console.WriteLine($"1. iratás x = {x}, x++ = {x++}");
            Console.WriteLine($"2. iratás x = {x}, x++ = {x++}");
            Console.WriteLine($"1. iratás y = {y}, ++y = {++y}");
            Console.WriteLine($"2. iratás y = {y}, ++y = {++y}");
            Console.ReadKey();
        }
    }
}
