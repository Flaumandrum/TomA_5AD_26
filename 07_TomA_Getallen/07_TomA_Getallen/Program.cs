using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_TomA_Getallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 01/10/2026
            // Project Getallen

            // Velden
            int _getal1 = 0, _getal2 = 0, _getal3 = 0;

            // Programma

            try
            {
                // Stap 1: Vraag een eerste getal +opslaan
                Console.Write("Geef een eerste natuurlijk getal: ");
                _getal1 = int.Parse(Console.ReadLine());
                
                // Stap 2: Vraag een tweede getal +opslaan
                Console.Write("\nGeef een tweede natuurlijk getal: ");
                _getal2 = int.Parse(Console.ReadLine());
                
                // Stap 3: Vraag een derde getal +opslaan.
                Console.Write("\nGeef een derde natuurlijk getal: ");
                _getal3 = int.Parse(Console.ReadLine());

                // Scherm wissen
                Console.Clear();

                // Stap 4: Toon de juiste tekst
                Console.WriteLine($"Dit was het 3de getal: {_getal3.ToString()}\nDit was het 2de getal:{_getal2.ToString()}\nDit was het 1ste getal:{_getal1.ToString()}");
                Console.WriteLine("\nDruk op enter om af te sluiten.");
            }
            catch
            {
                // Scherm wissen
                Console.Clear();

                // foutmelding
                Console.WriteLine("U gaf geen getal in.");
                Console.WriteLine("\nDruk op enter om af te sluiten.");
            }

        }
    }
}
