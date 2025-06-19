using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static int ile_cyfr(int x)
        {
            int i = 0;
            while (x/10>0)
            {
                x = x / 10;
                i++;
            }
            return i + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba 0 ma {0} cyfrę", ile_cyfr(0));
            Console.WriteLine("Liczba 1234 ma {0} cyfry", ile_cyfr(1234));
            //Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jako 
            //argument tej funkcji.Napisz program wykorzystujący funkcję ile_cyfr.

        }
    }
}
