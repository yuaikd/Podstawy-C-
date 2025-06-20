using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7_while_dodatkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisz program obliczający wartość n! (n silnia, n!=1*2*…*n) dla wczytanej z klawiatury
            //liczby naturalnej n.Użyj pętli while.Np.: dla n = 5 wypisz wynik 5 != 120.
            int n;
            int silnia = 1;
            Console.WriteLine("Podaj liczbę naturalną n: ");
            n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                silnia *= i;
                i++;
            }
            Console.WriteLine(n + "! = " + silnia);

            Console.ReadKey();

        }
    }
}
