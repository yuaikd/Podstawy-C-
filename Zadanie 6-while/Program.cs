using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6_while
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program, który będzie umożliwiał użytkownikowi obliczenia pól figur płaskich.
            //Jeżeli użytkownik wybierze 1, to powinien mieć możliwość obliczenia pola prostokąta,
            //dla 2 – pola kwadratu, a dla 3 – pola trójkąta. Program powinien pytać użytkownika, które
            //pole chce obliczyć aż do momentu, kiedy użytkownik wpisze 0(zero).
            int wybor;
            double a, b, h;
            do
            {
                Console.WriteLine("Wybierz figurę, dla której chcesz obliczyć pole: ");
                Console.WriteLine("1 - prostokąt");
                Console.WriteLine("2 - kwadrat");
                Console.WriteLine("3 - trójkąt");
                Console.WriteLine("0 - zakończ program");
                wybor = int.Parse(Console.ReadLine());
                switch (wybor)
                {
                    case 1:
                        Console.WriteLine("Podaj długość boku a: ");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj długość boku b: ");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Pole prostokąta wynosi: " + a * b);
                        break;
                    case 2:
                        Console.WriteLine("Podaj długość boku a: ");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Pole kwadratu wynosi: " + a * a);
                        break;
                    case 3:
                        Console.WriteLine("Podaj długość boku a: ");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj wysokość h: ");
                        h = double.Parse(Console.ReadLine());
                        Console.WriteLine("Pole trójkąta wynosi: " + 0.5 * a * h);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Nie ma takiej figury!");
                        break;
                }
            } while (wybor != 0);


        }
    }
}
