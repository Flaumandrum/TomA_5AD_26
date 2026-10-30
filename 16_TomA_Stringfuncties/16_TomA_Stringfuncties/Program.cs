using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_TomA_Stringfuncties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 27/10/2026
            // Oef 47 STringfuncties1

            //Velden
            String _zin1 = "", _zin2 = "";
            Byte _keuze = 0;

            // Programma
            do
            {
                // Scherm leegmaken 
                Console.Clear();

                //Toon keuzemenu.
                //Bij de eerste optie kan hij een woord of zin ingeven en  deze moet minimum 5 tekens zijn.
                //Bij optie 2 kan hij een hele reeks bewerkingen op deze zin laten uitvoeren.
                Console.WriteLine("Maak uw keuze uit onderstaand menu: ");
                Console.WriteLine("\n   1) Geef een zin in van minsten 5 tekens. \n   2) voer bewerkingen uit op deze zin");
                Console.WriteLine("   3) Afsluiten");

                try
                {
                    // Keuze vragen + opslaan
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Scherm leegmaken 
                    Console.Clear();

                    // Als keuze 1:
                    if(_keuze == 1)
                    {
                        do
                        {
                            // Scherm leegmaken 
                            Console.Clear();

                            // Vraag een zin + opslaan 
                            Console.Write("Geef een zin van minsten 5 tekens in: ");
                            _zin1 = Console.ReadLine();

                            if(_zin1.Length < 5)
                            {
                                // Scherm leegmaken 
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("Uw zin bevatte geen 5 tekens");
                                Console.WriteLine("\nDruk op een toets om nog eens te proberen.");
                                Console.ReadKey();
                            }

                        } while (_zin1.Length < 5);
                    }
                    else if (_keuze == 2)
                    {

                        //Er moet bij optie 2 eerst worden nagegaan of er wel een zin is ingegeven.
                        if(_zin1 != "")
                        {
                            //Dit zijn de bewerkingen die worden uitgevoerd bij optie 2:
                            //	Zeg hoeveel tekens het bevat
                            Console.WriteLine($"Uw zin bevat {_zin1.Length.ToString()} tekens.");

                            //	Zet elke letter in een hoofdletter en toon het woord.
                            Console.WriteLine($"\nDit is uw zin in hoofletters: {_zin1.ToUpper()}");

                            //	Zet elke letter in een kleine letter en toon het woord.
                            Console.WriteLine($"\nDit is uw zin in kleine letters: {_zin1.ToLower()}");

                            //	Wat de eerste 3 tekens zijn(toon deze op het scherm)
                            Console.WriteLine($"\nDit zijn de eerst 3 tekens van je zin: {_zin1.Substring(0, 3)}");

                            //	Wat de laatste 4 tekens zijn(toon deze op het scherm)
                            Console.WriteLine($"\nDit zijn de laatste 4 tekens van je zin: {_zin1.Substring(_zin1.Length-4, 4)}");

                            // Pauzeren
                            Console.WriteLine("\nDruk op een toets om verder te gaan met de bewerkingen");
                            Console.ReadKey();

                            // Scherm leegmaken 
                            Console.Clear();

                            //	Zet 5 spaties voor en achter de zin. (toon op het scherm)
                            Console.WriteLine("Voor het vervolg van de bewerkingen, zetten we 5 spaties voor en achter het woord.");
                            _zin1 = $"     {_zin1}     ";
                            Console.WriteLine($"hier door krijg je: {_zin1}");

                            //	Verwijder de spaties voor het woord(toon op het scherm)
                            _zin1 = _zin1.TrimStart();
                            Console.WriteLine($"\nDe 5 spaties vooraan werden verwijderd: {_zin1}");
                            
                            //	Verwijder de spaties achter het woord(toon op het scherm)
                            _zin1 = _zin1.TrimEnd();
                            Console.WriteLine($"\nDe 5 spaties achteraan werden nu ook verwijderd: {_zin1}");


                            //	Zet 5 spaties voor en achter de zin. (toon op het scherm)
                            Console.WriteLine("We zetten weer 5 spaties voor en achter het woord.");
                            _zin1 = $"     {_zin1}     ";
                            Console.WriteLine($"hier door krijg je: {_zin1}");

                            //	Verwijder de spaties voor EN achter het woord in 1 keer(toon op het scherm)
                            _zin1 = _zin1.Trim();
                            Console.WriteLine($"\nDe 5 spaties voor- en achteraan werden in 1 keer verwijderd: {_zin1}");

                            // Pauzeren
                            Console.WriteLine("\nDruk op een toets om verder te gaan met de bewerkingen");
                            Console.ReadKey();

                            // Scherm leegmaken 
                            Console.Clear();

                            //	Zoek of er een e in het woord of de zin zit
                            Console.WriteLine("Voor het vervolg van de bewerkingen, bekeken we of er een e in zin zit.");
                            int plaats = _zin1.IndexOf("e");
                            //a.Als er een e in de zin zit vervang je die door het cijfer 3
                            if(plaats != -1)
                            {
                                Console.WriteLine($"\nEr zat minsten 1 e in je zin." +
                                    $"\nWe hebben ze allemaal veranderd naar 3: {_zin1.Replace("e","3")}");

                            }
                            //b.Als er geen e in het woord zit, zeg je “Niet van toepassing”
                            else
                            {
                                Console.WriteLine($"\nEr zat geen e in het woord.");

                            }
                            // Pauzeren
                            Console.WriteLine("\nDruk op een toets om verder te gaan met de bewerkingen");
                            Console.ReadKey();

                            // Scherm leegmaken 
                            Console.Clear();

                            //	Vraag de gebruiker een 2de zin in te geven. 
                            Console.WriteLine("Voor het vervolg van de bewerkingen, moet je nog een extra zin in geven.");
                            Console.WriteLine("We zetten de zinnen dan alfabetisch.");
                            Console.Write("Geef je tweede zin in: ");
                            _zin2 = Console.ReadLine();
                            SByte orde = Convert.ToSByte(String.Compare(_zin1, _zin2));

                            //a.Rangschik deze woorden alfabetisch
                            if(orde < 0)
                            {
                                Console.WriteLine($"{_zin1} \nkomt alfabetisch voor \n {_zin2}");
                            }
                            else if(orde > 0)
                            {
                                Console.WriteLine($"{_zin2} \nkomt alfabetisch voor \n {_zin1}");
                            }
                            //b.Tenzij ze identiek zijn, dan zeg je: “je gaf hetzelfde woord of dezelfde tekst in” 
                            else
                            {
                                Console.WriteLine("Beide zinnen zijn gelijk!");
                            }
                            Console.WriteLine("\nDruk op een toets om verder te gaan met de bewerkingen");
                            Console.ReadKey();
                        }
                        else
                        {
                            // Foutmelding
                            Console.WriteLine("U moet eerst bij optie 1 een zin in geven.");
                            Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                            Console.ReadKey();
                        }
                    }
                    else if (_keuze == 3)
                    {
                        // begeleid de gebruiker 
                        Console.WriteLine("tot een volgende keer .");
                        Console.WriteLine("\nDruk op een toets om af te sluiten.");
                    }
                    else
                    {
                        // Foutmelding
                        Console.WriteLine("U gaf geen geldige keuze in.");
                        Console.WriteLine("\nDruk op een toets om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();

                    }
                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("U gaf geen getal in.");
                    Console.WriteLine("Druk op een toets om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();
                }
            } while (_keuze != 3);

        }
    }
}
