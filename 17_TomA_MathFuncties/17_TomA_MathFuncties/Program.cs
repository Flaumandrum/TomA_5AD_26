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
                        bool herhalen = true;

                        do
                        {
                            // Scherm leegmaken
                            Console.Clear();

                            try
                            {
                                // Stap 5: Vraag 2 getallen + opslaan
                                Console.Write("Geef een eerste getal: ");
                                int getal1 = int.Parse(Console.ReadLine());

                                Console.Write("\nGeef een tweede getal: ");
                                int getal2 = int.Parse(Console.ReadLine());

                                // Scherm leegmaken
                                Console.Clear();

                                // Stap 6: toon menu(kleinste, grootste )
                                Console.WriteLine("Welke bewerking wil je uitvoeren?");
                                Console.WriteLine("  1) bepaal het kleinste getal");
                                Console.WriteLine("  2) bepaal het grootste getal");

                                try
                                {

                                    Console.Write("\nGeef uw keuze: ");
                                    Byte keuze = Byte.Parse(Console.ReadLine());

                                    // Scherm leegmaken
                                    Console.Clear();

                                    // Stap 7: geef het juiste antwoord
                                    if (keuze == 1)
                                    {
                                        Console.WriteLine($"Het kleinste getal is: {Math.Min(getal1, getal2).ToString()}");
                                        Console.ReadKey();

                                        // Lussen stoppen
                                        herhalen = false;
                                    }
                                    else if(keuze == 2)
                                    {
                                        Console.WriteLine($"Het grootste getal is: {Math.Max(getal1, getal2).ToString()}");
                                        Console.ReadKey();

                                        // Lussen stoppen
                                        herhalen = false;
                                    }
                                    else
                                    {
                                        // foutmelding
                                        Console.WriteLine("Dit is geen juiste keuze. ");
                                        Console.WriteLine("\nDruk op enter en probeer opnieuw.");
                                        Console.ReadKey();
                                    }

                                    

                                }
                                catch
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    // Foutmelding
                                    Console.WriteLine("U gaf geen getal in.");
                                    Console.WriteLine("\nDruk op enter om terug te keren naar deze keuze.");
                                    Console.ReadKey();
                                }


                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen getal in.");
                                Console.WriteLine("\nDruk op enter om terug te keren naar deze keuze.");
                                Console.ReadKey();
                            }
                        } while (herhalen);
                    }

                    // Als 2: teken en absolute waarde
                    else if (_keuze == 2)
                    {
                        bool herhalen = true;

                        do
                        {
                            // Scherm leegmaken
                            Console.Clear();

                            try
                            {
                                // Stap 8: vraag getal +opslaan
                                Console.Write("Geef een getal: ");
                                int getal = int.Parse(Console.ReadLine());

                                // Scherm leegmaken
                                Console.Clear();

                                // Toon het menu
                                Console.WriteLine("Welke bewerking wil je uitvoeren?");
                                Console.WriteLine("  1) geef weer of het getal positief of negatief is");
                                Console.WriteLine("  2) geef de absolute waarde");
                                try
                                {

                                    Console.Write("\nGeef uw keuze: ");
                                    Byte keuze = Byte.Parse(Console.ReadLine());

                                    // Scherm leegmaken
                                    Console.Clear();

                                    // Stap 9: Toon positief of negatief
                                    if (keuze == 1)
                                    {
                                        // Kijk of het getal positief is 
                                        if(Math.Sign(getal)==1)
                                        {   
                                            Console.WriteLine("Het getal is positief");
                                            
                                        }
                                        // Kijk of het 0 is
                                        else if (Math.Sign(getal) == 0)
                                        {
                                            Console.WriteLine("Het getal is nul");
                                        }
                                        // Anders is het negatief
                                        else
                                        {
                                            Console.WriteLine("Het getal is negatief");
                                        }

                                        Console.ReadKey();

                                        // Lussen stoppen
                                        herhalen = false;
                                    }
                                    // Stap 10: Toon absolute waarde
                                    else if (keuze == 2)
                                    {
                                        Console.WriteLine($"De absolute waarde van het getal is: {Math.Abs(getal).ToString()}");
                                        Console.ReadKey();

                                        // Lussen stoppen
                                        herhalen = false;
                                    }
                                    else
                                    {
                                        // foutmelding
                                        Console.WriteLine("Dit is geen juiste keuze. ");
                                        Console.WriteLine("\nDruk op enter en probeer opnieuw.");
                                        Console.ReadKey();
                                    }

                                }
                                catch
                                {
                                    // Scherm leegmaken
                                    Console.Clear();

                                    // Foutmelding
                                    Console.WriteLine("U gaf geen getal in.");
                                    Console.WriteLine("\nDruk op enter om terug te keren naar deze keuze.");
                                    Console.ReadKey();
                                }
                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen getal in.");
                                Console.WriteLine("\nDruk op enter om terug te keren naar deze keuze.");
                                Console.ReadKey();
                            }
                        } while (herhalen);
                    }
                    //Als 3: afronden
                    else if (_keuze == 3)
                    {
                        bool herhalen = true;

                        do
                        {
                            // Scherm leegmaken
                            Console.Clear();

                            try
                            {
                                // Stap 11: Vraag een kommagetal van minstens 3 cijfers na de komma
                                Console.Write("Geef een getal met minsten 3 cijfers na de komma: ");
                                double getal = double.Parse(Console.ReadLine().Replace(".",","));

                                // Scherm leegmaken
                                Console.Clear();
                                string test = getal.ToString();

                                // Stap 12: Ga na of er 3 cijfers zijn na de komma
                                if (getal.ToString().IndexOf(",")!= -1 && (getal.ToString().Length-getal.ToString().IndexOf(",")>3))
                                {
                                    // Stap 13: Toon het getal afgerond tot 2 cijfers na de komma
                                    Console.WriteLine($"Het afgeronde getal is: {Math.Round(getal,2).ToString()}");
                                    // Stap 14 : toon het getal afgerond naar dichtstbijzijnde natuurlijk getal
                                    Console.WriteLine($"Het afgeronde getal is: {Math.Round(getal).ToString()}");
                                    // Stap 15: Toon het getal met het 2de cijfer na de komma afgerond naar boven
                                    Console.WriteLine($"Het afgeronde getal is: {(Math.Ceiling(getal*100)/100).ToString()}");
                                }
                                else
                                {
                                    // Foutmelding
                                    Console.WriteLine("U gaf geen getal in met minsten 3 cijfers na de komma.");
                                }

                                Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                                Console.ReadKey();

                                // Lussen stoppen
                                herhalen = false;

                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen getal in.");
                                Console.WriteLine("\nDruk op enter om terug te keren naar deze keuze.");
                                Console.ReadKey();
                            }
                        } while (herhalen);
                    }

                    //Als 4: 	Macht
                    else if (_keuze == 4)
                    {
                        bool herhalen = true;

                        do
                        {
                            // Scherm leegmaken
                            Console.Clear();

                            try
                            {

                                // Stap 16: Vraag een getal + opslaan
                                Console.Write("Geef een getal in:");
                                int getal = int.Parse(Console.ReadLine());

                                // Stap 17: Bereken de 2de, 3de en 4de macht
                                double tweede = Math.Pow(getal, 2);
                                double derde = Math.Pow(getal, 3);
                                double vierde = Math.Pow(getal, 4);

                                // Stap 18: Toon resultaat
                                Console.WriteLine("Hier zijn de uitkomsten van de verschillende machten:");
                                Console.WriteLine($"tot de tweede macht: {tweede.ToString()}");
                                Console.WriteLine($"tot de derde macht: {derde.ToString()}");
                                Console.WriteLine($"tot de vierder macht: {vierde.ToString()}");
                                Console.ReadKey();

                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen getal in.");
                                Console.WriteLine("\nDruk op enter om terug te keren naar deze keuze.");
                                Console.ReadKey();
                            }
                        } while (herhalen);
                    }
                    // Als 5: Vierkantswortel
                    else if (_keuze == 5)
                    {
                        bool herhalen = true;

                        do
                        {
                            // Scherm leegmaken
                            Console.Clear();

                            try
                            {
                                // Stap 19: Vraag een getal + opslaan
                                Console.Write("Geef een getal in:");
                                int getal = int.Parse(Console.ReadLine());

                                // Stap 20: Bereken de vierkantswortel + afronden
                                double uitkomst = Math.Sqrt(getal);

                                // Stap 21: Toon resultaat
                                Console.WriteLine($"de vierkantswortel van {getal.ToString()} =  {uitkomst.ToString()}");
                                Console.ReadKey();
                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen getal in.");
                                Console.WriteLine("\nDruk op enter om terug te keren naar deze keuze.");
                                Console.ReadKey();
                            }
                        } while (herhalen);
                    }
                    // Als 6: Inhoud cilinder
                    else if (_keuze == 6)
                    {
                        bool herhalen = true;

                        do
                        {
                            // Scherm leegmaken
                            Console.Clear();

                            try
                            {
                                // Stap 22: Vraag straal van het bodemvlak + opslaan
                                Console.Write("Geef de straal in van het grondvlak in cm:");
                                double straal = double.Parse(Console.ReadLine().Replace(".",","));

                                // Stap 23: Vraag hoogte van de cilinder + opslaan
                                Console.Write("Geef de hoogte in van de cilinder in cm:");
                                double hoogte = double.Parse(Console.ReadLine().Replace(".", ",")));

                                // Stap 24: maak de berekening voor inhoud en omtrek, rond af tot 2 cijfers na de komma +toon resultaat
                                Console.WriteLine($"De inhoud van uw cilinder is: {(Math.Round(Math.Pow(straal, 2)*Math.PI* hoogte),2).ToString()} in cm³");
                                Console.WriteLine($"De omtrek van de cilinder is: {Math.Round(Math.Pow(straal,2)*Math.PI *2 +2 * Math.PI * straal,2).ToString()} in cm²");

                                Console.WriteLine("\nDruk op enter om terug te keren naar deze keuze.");
                                Console.ReadKey();
                            }
                            catch
                            {
                                // Scherm leegmaken
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen getal in.");
                                Console.WriteLine("\nDruk op enter om terug te keren naar deze keuze.");
                                Console.ReadKey();
                            }
                        } while (herhalen);
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
