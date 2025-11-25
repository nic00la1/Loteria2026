using System;
using System.Linq;

namespace Loteria2026
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile wygenerować losowań?");
            string ileLosowan = Console.ReadLine();
            int ileLosowanInt = int.Parse(ileLosowan);

            Console.WriteLine("Zestawy wylosowanych liczb: ");
            int i = 1;
            while (i <= ileLosowanInt)
            {
                Console.WriteLine($"Losowanie {i}: {string.Join(" ", Losuj6Liczb())}");
                i++;
                
            }

            static List<int> Losuj6Liczb()
            {
                Random random = new Random();
                HashSet<int> liczby = new HashSet<int>(); // Dzięki HashSet - W jednym zestawie liczby nie mogą się powtarzać.
                liczby.Add(liczba);

                while (liczby.Count < 6)
                {
                    int liczba = random.Next(1, 50);
                    liczby.Add(liczba);
                }

                return new List<int>(liczby);
            }
        }
    }
}
