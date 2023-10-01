using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rok
{
    class Test
    {
        static void Main(string[] args)
        {
            int rok = 1900;
            while(rok<1951)
            {
                if((rok%4==0) && (rok % 100 != 0) || (rok % 4 == 0) && (rok % 100 == 0) && (rok % 400 == 0))
                {
                    Console.WriteLine("Rok {0} jest rokiem przestępnym", rok);
                }
                rok++;
            }
            Console.ReadLine();
        }
    }
}
