//zadamoe 2. obliczamy objętość kuli

using System;

class Kula
{
    public static float Obliczobjetosc(float promien)
    {
        float objetosc = 0.0F; //single-precision floating-point

        objetosc = (float)(4.0 / 3 * Math.PI * promien * promien * promien);

        return objetosc;
    }

    public static void Main()
    {
        float promien = 0.0F;
        float objetosc = 0.0F;

        Console.Write("Podaj promień: ");
        promien = float.Parse(Console.ReadLine());

        objetosc = Obliczobjetosc(promien);
        Console.WriteLine("Objętość kuli: " + objetosc);
    }
}