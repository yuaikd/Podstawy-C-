using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n (n>1). Narysuj na ekranie z gwiazdek trójkąt równoramienny, który
            //nie jest trójkątem prostokątnym. Użyj pętli for. Przykładowo dla n = 3 narysowany trójkąt
            //powinien wyglądać:
            Console.WriteLine("Podaj liczbe wierszy: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbe kolumn: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int i;
            int j;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= k; j++)
                    Console.Write("*");

                Console.WriteLine("");
            }


            Console.ReadKey(true);
        }
    }
}
