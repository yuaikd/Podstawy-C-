﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6_warunki
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący numer miesiąca (od 1 do 12) i wypisujący na ekranie nazwę tego
         // miesiąca.Użyj instrukcji wyboru switch.
            int miesiąc;
            Console.WriteLine("Podaj numer miesiąca: ");
            Int32 miesiac = Int32.Parse(Console.ReadLine());  
            switch (miesiac)
            {
                case 1:
                    Console.WriteLine("Styczeń");
                    break;
                case 2:
                    Console.WriteLine("Luty");
                    break;
                case 3:
                    Console.WriteLine("Marzec");
                    break;
                case 4:
                    Console.WriteLine("Kwiecień");
                    break;
                case 5:
                    Console.WriteLine("Maj");
                    break;
                case 6:
                    Console.WriteLine("Czerwiec");
                    break;
                case 7:
                    Console.WriteLine("Lipiec");
                    break;
                case 8:
                    Console.WriteLine("Sierpień");
                    break;
                case 9:
                    Console.WriteLine("Wrzesień");
                    break;
                case 10:
                    Console.WriteLine("Październik");
                    break;
                case 11:
                    Console.WriteLine("Listopad");
                    break;
                case 12:
                    Console.WriteLine("Grudzień");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego miesiąca");
                    break;
            }
            Console.ReadKey();

        }
        }
}
