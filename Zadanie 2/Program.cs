using System;

namespace Zadanie_2
{
    //2. Zdefiniuj strukturę o nazwie Uczen zawierającą pola: imie, nazwisko i tablice ocen.
  //  Pobierz od użytkownika liczbę uczniów i zadeklaruj odpowiednią tablicę struktur
//umożliwiającą przechowanie informacji o imionach, nazwiskach i ocenach uczniów.
//Następnie pobierz dane od użytkownika i w sposób czytelny wypisz wszystko na ekranie
    struct Uczen
    {
        public string Imie, Nazwisko;
        public int[] Oceny;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Uczen[] uczniowie;
            int iluUczniow, iloscOcen;

            Console.WriteLine("Podaj liczbę uczniów:");
            iluUczniow = int.Parse(Console.ReadLine());
            uczniowie = new Uczen[iluUczniow];

            for (int i = 0; i < iluUczniow; i++)
            {
                Console.WriteLine($"Podaj imię ucznia {i + 1}:");
                uczniowie[i].Imie = Console.ReadLine();

                Console.WriteLine($"Podaj nazwisko ucznia {i + 1}:");
                uczniowie[i].Nazwisko = Console.ReadLine();

                Console.WriteLine($"Podaj liczbę ocen ucznia {i + 1}:");
                iloscOcen = int.Parse(Console.ReadLine());
                uczniowie[i].Oceny = new int[iloscOcen];

                for (int j = 0; j < iloscOcen; j++)
                {
                    Console.WriteLine($"Podaj ocenę {j + 1} ucznia {i + 1}:");
                    uczniowie[i].Oceny[j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("Lista uczniów i ich ocen: ");
            for (int i = 0; i < iluUczniow; i++)
            {
                Console.WriteLine($"{i + 1}. {uczniowie[i].Imie} {uczniowie[i].Nazwisko}: ");
                foreach (int ocena in uczniowie[i].Oceny)
                {
                    Console.Write($"{ocena} ");
                }
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
