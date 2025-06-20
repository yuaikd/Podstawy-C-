using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i
            //największej z tych liczb.

            double a, b, c;
            Console.WriteLine("podaj pierwszą liczbę: ");
            a= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj drugą liczbę: ");
            b= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj trzecią liczbę: ");
            c= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj trzecią liczbę: ");
            if (a > b && b > c)
                Console.WriteLine("{0}, {1}, {2}", a, b, c);
            else if (b > c && c > a)
                Console.WriteLine("{0}, {1}, {2}", b, c, a);
            else if (c > b && b > a)
                Console.WriteLine("{0}, {1}, {2}", c, b, a);
            else if (a > c && c > b)
                Console.WriteLine("{0}, {1}, {2}", a, c, b);
            else if (b > a && a > c)
                Console.WriteLine("{0}, {1}, {2}", b, a, c);
            else if (c > a && a > b)
                Console.WriteLine("{0}, {1}, {2}", c, a, b);
            Console.ReadKey();





        }
    }
}
