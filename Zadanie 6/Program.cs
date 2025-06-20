using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i
            //iloraz.
            double a, b;
            Console.Write("podaj liczbę a=");
            a= Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj liczbę b=");
            b= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("suma={0}", a+b);
            Console.WriteLine("różnica={0}", a-b);
            Console.WriteLine("iloraz={0}", a/b);
            Console.WriteLine("iloczyn={0}", a*b);
            Console.ReadKey(true);
        }
    }
}
