//zadanie 0

//szablon konsolowej aplikacji

//zadanie 1a. wyświetl na ekranie hello, wolrd
using System; //za pomoca using dołączamy pewne biblioteki
using System.Collections.Generic; //średniki są wymagane
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)//wewnątrz klasy mamy funkcję Main
        {
            Console.WriteLine("Zespół Szkół Komunikacji");
            Console.WriteLine("Technikum Komunikacji");//wypisz - w tym wypadku wypisze tekst na ekranie
            Console.ReadLine(); //odczytaj z konsoli - konsola nie będzie automatycznie zamykana po uruchomieniu
        }
    }
}
