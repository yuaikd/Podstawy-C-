using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Napisać program wczytujący liczbę całkowitą n (n>2) i wypisujący na ekranie wartość sumy
            //1 + 2 +…+n.Do obliczenia wartości sumy użyj pętli for.
            //3 (3+(3-1)+(3-2)
            Console.WriteLine("Podaj liczbę całkowitą: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int i;
            int wynik = 0;
            for (i = 1; i <= n; i++)

                wynik += i;
                
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
