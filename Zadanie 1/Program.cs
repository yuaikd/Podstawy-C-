﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{//Zdefiniuj strukturę o nazwie Osoba posiadającą trzy pola: imie, nazwisko i rok_urodzenia.
    //Zadeklaruj zmienną typu strukturalnego o nazwie o, wczytaj do niej wszystkie wartości pól od
    //użytkownika i wypisz wszystkie pobrane wartości pól na ekranie.
    struct Osoba
    {
        public string imie, nazwisko;
        public int rok_urodzenia;
        }
    class Program
    {

        static void Main(string[] args)
        {
            Osoba o = new Osoba();
            Console.WriteLine("Podaj imie:");
            o.imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            o.nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj rok urodzenia:");
            o.rok_urodzenia = int.Parse(Console.ReadLine());
            Console.WriteLine($"Imie: {o.imie}, Nazwisko: {o.nazwisko}, Rok urodzenia: {o.rok_urodzenia}");
            Console.ReadKey();
        }
        
    }
}
