using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10_while_dodatkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program sumujący kolejne liczby całkowite podawane przez użytkownika, aż do
            //napotkania zera. Wypisz otrzymaną sumę na ekranie.Użyj pętli do -while.
            int liczba;
            int suma = 0;
            do
            {
                Console.WriteLine("Podaj liczbę całkowitą: ");
                liczba = int.Parse(Console.ReadLine());
                suma += liczba;
            } while (liczba != 0);
            Console.WriteLine("Suma podanych liczb wynosi: " + suma);
            Console.ReadKey();

        }
    }
}
