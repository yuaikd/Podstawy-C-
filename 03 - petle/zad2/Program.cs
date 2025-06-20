using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący wartość liczby naturalnej n (n>=0), obliczający wartość 2^n (2 dopotęgi n)
            //i wypisujący wynik na ekranie w formacie(np.dla n = 10) : 2 ^
            //10 = 1024.Do obliczeniawartości wyrażenia użyj pętli for.
            Console.WriteLine("Podaj liczbę naturalną: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            int wynik = 1;
            for (i = 1; i <= n; i++)
            
                wynik *=2;
            Console.WriteLine("{0}", wynik);
            
            Console.ReadKey();

        }
    }
}
