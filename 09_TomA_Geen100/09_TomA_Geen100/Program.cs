using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _09_TomA_Geen100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 09/10/2026
            // Geen 100

            // Velden
            int _getalGebruiker = 0;
            const int _vergelijk = 100;
            

            // Programma
            // Stap 1: Intro
            Console.WriteLine("Welkom in het programma waarbij je geen 100 mag ingeven. ");
            Console.WriteLine("\nDruk op enter om verder te gaan");
            Console.ReadKey();

            // scherm leegmaken
            Console.Clear();
            try
            {
                // Stap 2: Vraag getal +opslaan
                Console.Write("Geef een getal in dat niet 100 is: ");
                _getalGebruiker = int.Parse(Console.ReadLine());

                // Stap 3: evalueer het getal 100 is
                // Als groter dan 100
                if (_getalGebruiker > _vergelijk)
                {
                    // Toon Tekst
                    Console.WriteLine("Het getal is groter dan 100");
                }

                // Als kleiner dan 100
                else if (_getalGebruiker < _vergelijk)
                {
                    // Toon Tekst
                    Console.WriteLine("Het getal is kleiner dan 100");
                }
                // Als 100
                else
                {
                    // Toon Tekst
                    Console.WriteLine("Je gaf 100 in. Dit is tegen de regels.");
                }
            }
            catch
            {
                // scherm leegmaken
                Console.Clear();
                // foutmelding
                Console.WriteLine("u gaf geen getal in");
            }
            

        }
    }
}
