using System;

class Przykład
{
    static void Main()
    {
        int num = 0;
        Console.Write("Wprowadź liczbę całkowitą: ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("num = " + num);
    }
}