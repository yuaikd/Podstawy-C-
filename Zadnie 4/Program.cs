using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadnie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej
         //  największej z tych liczb
            double a, b, c, d, e, min, max;
            Console.WriteLine("1 liczba: ");
            a= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2 liczba: ");
            b= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("3 liczba");
            c= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("4 liczba: ");
            d= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("5 liczba: ");
            e= Convert.ToDouble(Console.ReadLine());
            min = a;
            if (b < min) min = b;

            else if (c < min) min = c;
            else if (d < min) min= d;
            else if (e < min) min= e;
            Console.WriteLine("najnizsza liczba to {0}", min);
            max = a;
            if (b > max) max= b;

            else if (c > max) max= c;
            else if (d > max) max= d;
            else if (e > max) max= e;
            Console.WriteLine("najwieksza liczba to {0}", max);
            Console.ReadKey();
        }
    }
}
