using System;
using System.IO;
using System.Text;

namespace Wyswietl
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rozmiar(int): {0}", sizeof(int));
            Console.WriteLine("rozmiar(float): {0}", sizeof(float));
            Console.WriteLine("rozmiar(char): {0}", sizeof(char));
            Console.WriteLine("rozmiar(double): {0}", sizeof(double));
            Console.WriteLine("rozmiar(bool): {0}", sizeof(bool));
            Console.ReadLine();
        }
    }
}