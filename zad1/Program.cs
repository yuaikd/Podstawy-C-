﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Napisać program wypisujący na ekranie kolejne liczby całkowite od 11 do 33. Użyj pętli for.
            int i;
            for (i = 11;i<=33;i++)
                Console.Write("{0}, ", i);
                  
            Console.ReadKey(true);
        }
    }
}
