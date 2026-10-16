using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_TomA_Hallo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 16/10/2026
            // Project Hallo

            // Velden
            Byte _keuze = 0;
            String _naam = null; 

            // Programma
            do
            {
                // Scherm wissen
                Console.Clear();

                // Stap 1: Toon het keuzemenu(hallo, hallo + naam, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu: ");
                Console.WriteLine("\n   1) Zeg hallo tegen de wereld");
                Console.WriteLine("   2) Zeg hallo tegen jezelf\n   3) Afsluiten");

                try
                {

                    // Stap 2: Vraag de keuze + opslaan
                    Console.Write("Uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Scherm wissen
                    Console.Clear();

                    // Stap 3: 
                    //	Als 1: 
                    if (_keuze == 1)
                    {
                        //		Stap 4: Toon juiste tekst
                        Console.WriteLine("Hallo wereld. " +
                            "\n\nDruk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }
                    //    Als 2: 
                    else if (_keuze == 2)
                    {
                        //		Stap 5: Vraag naam +opslaan
                        Console.Write("Geef uw naam: ");
                        _naam = Console.ReadLine();

                        // Scherm wissen
                        Console.Clear();

                        //        Stap 6: Toon juiste tekst
                        Console.WriteLine($"Hallo {_naam}. " +
                            $"\n\nDruk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }
                    //    Als 3:
                    else if (_keuze == 3)
                    {
                        //		Stap 7 Toon de afsluitteks
                        Console.WriteLine("Tot een volgende keer " +
                            "\n\nDruk op enter om af te sluiten.");
                        Console.ReadKey();
                    }

                    // In elk ander geval
                    else
                    {
                        // Foutmelding
                        Console.WriteLine("U gaf geen juiste keuze in. " +
                            "\nDruk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // Scherm wissen
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen getal in. " +
                        "\nDruk op enter om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();
                }
            }
            // Stap 8: indien keuze niet 3 is, ga naar stap 1
            while (_keuze != 3);

        }
    }
}
