using System;
using System.IO;
using System.Text;

namespace Zamiana
{
    class Test
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("a = {0}", b);
            //ZAMIANA
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("a = {0}", b);
            //ZAMIANA 2
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.ReadLine();
        }
    }
}