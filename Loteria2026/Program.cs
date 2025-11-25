using System;

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
                Console.WriteLine($"Losowanie {i}: ");
                i++;
            }
        }
    }
}
