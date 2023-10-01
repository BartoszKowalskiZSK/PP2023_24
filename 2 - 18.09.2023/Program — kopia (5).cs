using System;
using System.IO;
using System.Text;

namespace Konwertuj
{
    class Test
    {
        static void Main(string[] args)
        {
            int a = 10;
            float b = 10.23f;
            double c = 10.23;
            bool d = true;
            string e = a.ToString();
            string f = b.ToString();
            string g = c.ToString();
            string h = d.ToString();
            Console.WriteLine("Wartość a: {0}", e);
            Console.WriteLine("Wartość b: {0}", f);
            Console.WriteLine("Wartość c: {0}", g);
            Console.WriteLine("Wartość d: {0}", h);
            Console.ReadLine();
        }
    }
}