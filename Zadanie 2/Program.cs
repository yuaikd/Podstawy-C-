﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest
//dodatnia, ujemna, czy też równa zero

            Int32 a;
            Console.WriteLine("Podaj liczbę: ");
            a= Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("liczba dodatnia");
            else if (a == 0) 
                Console.WriteLine("liczba równa zero");
            else
               Console.WriteLine("liczba ujemna");
              Console.ReadKey();

        }
    }
}
