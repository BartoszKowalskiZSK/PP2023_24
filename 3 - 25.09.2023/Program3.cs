using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 1;
            while(a<=15)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.ReadKey();
            int b;
            b = 1;
            do
            {
                Console.WriteLine(b);
                b++;
            } while (b < 15);
            Console.ReadKey();
        }
    }
}
