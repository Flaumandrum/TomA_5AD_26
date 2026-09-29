using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_TomA_Favoriet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 29/09/2026
            // Project Favoriet

            // Velden 
            String _kleur = null, _dag = null, _seizoen = null;
            String _zin = null;

            // Programma
            // Stap 1: Vraag een kleur + opslaan
            Console.Write("Kies een kleur: ");
            _kleur = Console.ReadLine();

            // Scherm wissen
            Console.Clear();

            // Stap 2: Maak de zin + opslaan
            _zin = $"Je koos {_kleur}";

            // Stap 3: Toon de zin
            Console.WriteLine(_zin);
            Console.WriteLine("\nDruk op enter om verder te gaan");
            Console.ReadKey();

            // Scherm wissen
            Console.Clear();

            // Stap 4: Vraag een dag + opslaan
            Console.Write("Geef je favoriete weekdag: ");
            _dag = Console.ReadLine();

            // Scherm wissen
            Console.Clear();

            // Stap 5: Maak de zin + opslaan
            _zin = $"Je favoriete dag is {_dag}";

            // Stap 6: Toon de zin
            Console.WriteLine(_zin);
            Console.WriteLine("\nDruk op enter om verder te gaan");
            Console.ReadKey();

            // Scherm wissen
            Console.Clear();
            // Stap 7: Vraag een seizoen + opslaan
            Console.Write("Geef je favoriete seizoen: ");
            _seizoen = Console.ReadLine();

            // Scherm wissen
            Console.Clear();
            // Stap 8: Maak de zin + opslaan
            _zin = $"Je favoriete seizoen is {_seizoen}";

            // Stap 9: Toon de zin
            Console.WriteLine(_zin);
            Console.WriteLine("\nDruk op enter om verder te gaan");
            Console.ReadKey();

            // Scherm wissen
            Console.Clear();


        }
    }
}
