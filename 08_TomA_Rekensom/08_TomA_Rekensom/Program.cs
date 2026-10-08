using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_TomA_Rekensom
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Tom Adriaens
            // 08/10/2026
            // Project : Rekensom

            // Velden
            int _eersteGetal = 0;
            int _tweedeGetal = 0;
            int _som = 0;
            int _vermeerderd = 0;
            int _vermenigvuldigd = 0;
            int _gedeeld = 0;

            // uitbreiding 1
            const int _vermeerdering = 5;
            const int _vermenigvuldiging = 10;
            const int _deling = 2;


            // Programma.
            try
            {

                // Stap 1: Vraag het eerste getal +opslaan
                Console.Write("Geef een getal: ");
                _eersteGetal = int.Parse(Console.ReadLine());

                try
                {

                    // Stap 2: Vraag het tweede getal +opslaan
                    Console.Write("Geef nog een getal: ");
                    _tweedeGetal = int.Parse(Console.ReadLine());

                    // Stap 3: Maak de som + opslaan
                    _som = _eersteGetal + _tweedeGetal;

                    // Stap 4: Vermeerder met 5 + opslaan
                    _vermeerderd = _som + _vermeerdering;

                    // Stap 5: Vermenigvuldig met 10 + opslaan
                    _vermenigvuldigd = _vermeerderd * _vermenigvuldiging;

                    // Stap 6: Deel door 2 + opslaan
                    _gedeeld = _vermenigvuldigd / _deling;

                    // Scherm leegmaken
                    Console.Clear();

                    // Stap 7: Toon de tekst in de juiste vorm
                    Console.WriteLine($"U gaf het getal {_eersteGetal.ToString()} en getal {_tweedeGetal.ToString()} in.");
                    Console.WriteLine($"De som hiervan is {_som.ToString()}");
                    Console.WriteLine($"Dit getal werd vermeerder met 5.Dit gaf als uitkomst {_vermeerderd.ToString()}." +
                        $"\nDaarna werd er vermenigvuldig met 10.Dit gaf als uitkomst {_vermenigvuldigd.ToString()}");
                    Console.WriteLine($"Als laatste werd er gedeeld door 2.");
                    Console.WriteLine($"Het uiteindelijke resultaat is {_gedeeld.ToString()}.");

                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("Uw tweede getal was fout!");

                }
            }
            catch
            {
                // Scherm leegmaken 
                Console.Clear();

                // foutmelding
                Console.WriteLine("Uw eerste getal was fout!");

            }
        }
    }
}
