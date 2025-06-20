using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_rekurencje
{//Napisz funkcję, która wyznacza n-ty wyraz ciągu Fibonacciego zadany przez argument
   // wywołania funkcji wartości liczby naturalnej.Utwórz wersję rekurencyjną tej funkcji.
   // Napisz program testowy wykorzystujący napisaną funkcję.

    class Program
    {
        static long fib(long n)
        {if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return fib(n - 1) + fib(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę naturalną do obliczenia n-tego wyrazu ciągu Fibonacciego:");
            long n = long.Parse(Console.ReadLine());
            if (n < 0)
             Console.WriteLine("Liczba musi być liczbą naturalną.");
            else Console.WriteLine("fib({0})={1}", n, fib(n));
            Console.ReadKey();

        }
    }
}
