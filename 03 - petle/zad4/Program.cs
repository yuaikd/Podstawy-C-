using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt
            //posiadający n wierszy i k kolumn. Użyj pętli for.
            //n=2
            //n=k
            //**
            //*
            //*
            //*
            //*
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
