using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8_while_dodatkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisz program stwierdzający, czy zadana liczba n jest pierwsza. Użyj pętli while.
            int n;
            Console.WriteLine("Podaj liczbę naturalną n: ");
            n = int.Parse(Console.ReadLine());
            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Liczba " + n + " nie jest liczbą pierwszą.");
                    break;
                }
                i++;
            }
            if (i == n)
            {
                Console.WriteLine("Liczba " + n + " jest liczbą pierwszą.");
            }
            Console.ReadKey();

        }
    }
}
