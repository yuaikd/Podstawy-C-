﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to
            //liczba parzysta, czy też nieparzysta.
            Int32 a;
            Console.WriteLine("podaj liczbę: ");
            a= Convert.ToInt32(Console.ReadLine());
            { if (a % 2 == 0)
                    Console.WriteLine("liczba jest parzysta");
                else Console.WriteLine("liczba jest nieparzysta");
            }
            Console.ReadKey();
        }
    }
}
