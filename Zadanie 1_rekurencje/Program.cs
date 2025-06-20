using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_rekurencje
{//. Napisz funkcję , która oblicza wartość silni z zadanej przez argument wywołania funkcji
   // wartości liczby naturalnej.Utwórz wersję rekurencyjną tej funkcji.
   // Napisz program testowy wykorzystujący napisaną funkcję
  class Program
    {
        static long silnia(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * silnia(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę naturalną do obliczenia silni:");
            int n = int.Parse(Console.ReadLine());
            long wynik = silnia(n);
            Console.WriteLine($"Silnia z {n} wynosi: {wynik}");
            Console.ReadKey();
        }
    }

}
