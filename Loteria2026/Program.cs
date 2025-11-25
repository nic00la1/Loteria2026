using System;
using System.Linq;

namespace Loteria2026
{
    class Program
    {
        static Random random = new Random();
        // Globalna lista przechowująca wszystkie wylosowane liczby
        static List<int> wszystkieLiczby = new List<int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Ile wygenerować losowań?");
            WyswietlWyniki();
            WyswietlWystapieniaKazdejLiczby();
        }

        static void WyswietlWyniki()
        {
            string ileLosowan = Console.ReadLine();
            int ileLosowanInt = int.Parse(ileLosowan);

            int i = 1;
            while (i <= ileLosowanInt)
            {
                List<int> losowanie = Losuj6Liczb();
                wszystkieLiczby.AddRange(losowanie); // dodajemy liczby do globalnej listy

                Console.WriteLine($"Losowanie {i}: {string.Join(" ", losowanie)}");
                i++;
            }
        }

        static List<int> Losuj6Liczb()
        {
            HashSet<int> liczby = new HashSet<int>(); // Dzięki HashSet - W jednym zestawie liczby nie mogą się powtarzać.

            while (liczby.Count < 6)
            {
                int liczba = random.Next(1, 50);
                liczby.Add(liczba);
            }

            return new List<int>(liczby);
        }

        static void WyswietlWystapieniaKazdejLiczby()
        {
            for (int liczba = 1; liczba <= 49; liczba++)
            {
                int wystapienia = wszystkieLiczby.Count(x => x == liczba);
                Console.WriteLine($"Wystąpienia liczby {liczba}: {wystapienia}");
            }
        }
    }
}
