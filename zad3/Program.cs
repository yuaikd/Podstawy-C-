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
            //3. Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych, sortujący je niemalejąco i
            //wypisujący posortowane liczby na ekranie.

            int[] tab = new int[1000];
            Console.WriteLine("Podaj ilość elementów tablicy 1<=n>=1000: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j, tmp;
            for (i = 0; i < n; i++)
                for (j = i + 1; j < n; j++)
                    if (tab[i] > tab[j])
                    { tmp = tab[i]; tab[i] = tab[j]; tab[j] = tmp; }
            Console.Write("{0}, ", tab[i]);
            Console.Write("Elementy tablicy: ");
            for (i = 0; i < n; i++)
            { Console.Write("{0}, ",tab[i]);}
            Console.ReadKey(true);
        }
    }
    }
}
