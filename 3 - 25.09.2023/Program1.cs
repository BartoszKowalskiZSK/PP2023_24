using System;
using System.IO;
using System.Text;

namespace Arytmetyka
{
    class Test
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;

            int sum = a + b;
            int sub = a - b;
            int mul = a * b;
            float div = (float)a / (float)b;
            int rem = a % b;
            Console.WriteLine("Suma {0} + {1} = {2}", a, b, sum);
            Console.WriteLine("Różnica {0} - {1} = {2}", a, b, sub);
            Console.WriteLine("Mnożenie {0} * {1} = {2}", a, b, mul);
            Console.WriteLine("Dzielenie {0} / {1} = {2}", a, b, div);
            Console.WriteLine("Reszta z {0} oraz {1} wynosi {2}", a, b, rem);
            Console.ReadLine();
        }
    }
}