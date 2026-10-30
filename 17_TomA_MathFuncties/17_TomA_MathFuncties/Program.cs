using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _17_TomA_MathFuncties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 30/10/2026
            // Math functies

            // Velden
            Byte _keuze = 0;

            // Programma
            //  Stap 1: intro
            Console.WriteLine("Welkom in dit wiskunde programma.");
            Console.WriteLine("\nDruk op een toets om te starten.");
            Console.ReadKey();

            do
            {
                // Scherm leegmaken
                Console.Clear();

                // Stap 2:  Toon menu(grootste of kleinste, teken en abs, afronden, macht, Vierkantswortel, Inhoud cilinder, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu: ");
                Console.WriteLine("   1) Min of max \n   2) Bepaal het teken of absolute waarde");
                Console.WriteLine("   3) Afronden \n   4) Machtsverheffing \n   5) Vierkantswortel");
                Console.WriteLine("   6) Inhoud van een cilinder \n   7) Afsluiten");

                try
                {

                    // Stap 3: Vraag keuze +opslaan
                    Console.Write("Geef uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Stap 4
                    // Scherm leegmaken
                    Console.Clear();

                    // Als 1: grootste of kleinste
                    if (_keuze == 1)
                    {
                        // Stap 5: Vraag 2 getallen + opslaan

                        // Stap 6: toon menu(kleinst, grootste )

                        // Stap 7: geef het juiste antwoord
                    }

                    // Als 2: teken en absolute waarde
                    else if (_keuze == 2)
                    {

                        // Stap 8: vraag getal +opslaan

                        // Stap 9: Toon positief of negatief

                        // Stap 10: Toon absolute waarde

                    }
                    //Als 3: afronden
                    else if (_keuze == 3)
                    {
                        // Stap 11: Vraag een kommagetal van minstens 3 cijfers na de komma

                        // Stap 12: Ga na of er 3 cijfers zijn na de komma
                        // Stap 13: Toon het getal afgerond na de komma
                        // Stap 14 : toon het getal afgerond naar dichtstbijzijnde natuurlijk getal

                        // Stap 15: Toon het getal met het 2de cijfer na de komma afgerond naar boven
                    }

                    //Als 4: 	Macht
                    else if (_keuze == 4)
                    {
                        // Stap 16: Vraag een getal + opslaan

                        // Stap 17: Bereken de 2de, 3de en 4de macht

                        // Stap 18: Toon resultaat
                    }
                    // Als 5: Vierkantswortel
                    else if (_keuze == 5)
                    {
                        // Stap 19: Vraag een getal + opslaan

                        // Stap 20: Bereken de vierkantswortel + afronden

                        // Stap 21: Toon resultaat
                    }
                    // Als 6: Inhoud cilinder
                    else if (_keuze == 6)
                    {
                        // Stap 22: Vraag straal van het bodemvlak + opslaan

                        // Stap 23: Vraag hoogte van de cilinder + opslaan

                        // Stap 24: maak de berekening voor inhoud en omtrek, rond af tot 2 cijfers na de komma +toon resultaat
                    }
                    // Als 7 :
                    else if (_keuze == 7)
                    {
                        // Stap 25: Toon afsluittekst
                        Console.WriteLine("Tot een volgende keer .");
                        Console.WriteLine("\nDruk op enter om af te sluiten.");
                        Console.ReadKey();
                    }
                    // In elk ander geval.
                    else
                    {
                        // Foutmelding
                        Console.WriteLine("U gaf geen juist getal in.");
                        Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // Scherm leegmaken
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen getal in.");
                    Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();

                }

                // Stap 26: Als keuze niet 7 is: ga terug naar  Stap 2
            } 
            while (_keuze != 7);


        }
    }
}
