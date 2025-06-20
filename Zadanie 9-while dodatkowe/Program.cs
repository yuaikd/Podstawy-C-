using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9_while_dodatkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisz program obliczający sumę cyfr dla wczytanej z klawiatury liczby naturalnej.
         // Użyj pętli while.Np.: Dla liczby = 1342 trzeba obliczyć sumę 1 + 3 + 4 + 2.
            int liczba;
            Console.WriteLine("Podaj liczbę naturalną: ");
            liczba = int.Parse(Console.ReadLine());
            int suma = 0;
            while (liczba > 0)
            {
                suma += liczba % 10;
                liczba /= 10;
            }
            Console.WriteLine("Suma cyfr podanej liczby wynosi: " + suma);
            Console.ReadKey();
        }
    }
}
