using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _12_TomA_Keuzemenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens 
            // 15/10/2026
            // Oef 26: keuzemenu

            // Velden 
            Byte _keuze = 0;

            // Programma
            do
            {
                // Scherm wissen 
                Console.Clear();

                // Stap 1: Toon het keuzemenu(keuze1 keuze2, Keuze3, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu: ");
                Console.WriteLine("\n   1) Keuze1 \n   2) Keuze2 \n   3) Keuze3 \n   4) Afsluiten");

                try 
                { 
                    // Stap 2: Vraag de keuze + opslaan
                    Console.Write("\nUw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Scherm wissen 
                    Console.Clear();

                    // Stap 3:  Toon juiste tekst afhankelijk van de keuze
                    // als 1:
                    if (_keuze == 1)
                    {
                        // Toon de tekst
                        Console.WriteLine("U koos keuze1!");
                    }
                    // Als 2:
                    else if(_keuze == 2)
                    {
                        // Toon de tekst
                        Console.WriteLine("U koos keuze2!");
                    }
                    // als 3: 
                    else if (_keuze == 3)
                    {
                        // Toon de tekst
                        Console.WriteLine("U koos keuze3!");
                    }
                    // als 4:
                    else if (_keuze == 4)
                    {
                        // Toon de tekst
                        Console.WriteLine("Tot een volgende keer");
                    }
                    // als het iets anders is
                    else
                    {
                        // foutmelding 
                        Console.WriteLine("U gaf geen geldige keuze in!");
                    }
                    // Toon de tekst
                    Console.WriteLine("\nDruk op enter om verder te gaan.");
                    Console.ReadKey();
                }
                catch 
                {
                    // Scherm wissen 
                    Console.Clear();
                    // Foutmelding 
                    Console.WriteLine("U gaf geen getal in!");
                    Console.WriteLine("\nDruk op enter om naar het keuzemenu te gaan.");
                    Console.ReadKey();
                }
     
                // Stap 4: Als keuze niet 4 is, ga naar stap 1.
            } while (_keuze != 4);




        }
    }
}
