using System;
using System.IO;
using System.Text;

namespace Konwertuj
{
    class Test
    {
        static void Main(string[] args)
        {
            double a = 123456.789;
            int b = 0;

            //konwersja typów
            b = (int)a;
            Console.WriteLine("Wartość a: {0}", a);
            Console.WriteLine("Wartość b: {0}", b);
            Console.ReadLine();

        }
    }
}