using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_TomA_Afronden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 13/10/2026
            // Project afronden

            // Velden 
            float _floatvar = 0f;
            Double _doublevar = 0;
            Decimal _decimalvar = 0m;

            // Programma
            // Stap 1: Bereken 0.1 + 0.2 in de 3 typen van variabelen
            _floatvar = 0.1f + 0.2f;
            _doublevar = 0.1 + 0.2;
            _decimalvar = 0.1M + 0.2M;

            // Stap 2: Toon de resultaten
            Console.WriteLine($"float: {_floatvar.ToString()}");
            Console.WriteLine($"double: {_doublevar.ToString()}");
            Console.WriteLine($"decimal: {_decimalvar.ToString()}");

            Console.WriteLine("\nDruk op enter om verder te gaan.");
            Console.ReadKey();

            // scherm wissen 
            Console.Clear(); 

            // Stap 3:  ga na of float exact 0.3 weergeeft
            if(_floatvar == 0.3f)
            {
                //    Als ja:
                //            stap 4: Toon “exact 0.3”
                Console.WriteLine("float: Exact 0.3");
            }

            //	Als nee:
            else
            {
                //		Stap 5: Toon “niet 0.3”
                Console.WriteLine("float: Niet 0.3");
            }

            // Stap 6:  ga na of double exact 0.3 weergeeft
            if (_doublevar == 0.3D)
            {
                //    Als ja:
                //            stap 7: Toon “exact 0.3”
                Console.WriteLine("Double: Exact 0.3");
            }

            //	Als nee:
            else
            {
                //		Stap 8: Toon “niet 0.3”
                Console.WriteLine("Double: Niet 0.3");
            }
            // Stap 9:  ga na of decimal exact 0.3 weergeeft
            if (_decimalvar == 0.3M)
            {
                //    Als ja:
                //            stap 10: Toon “exact 0.3”
                Console.WriteLine("Decimal: Exact 0.3");
            }

            //	Als nee:
            else
            {
                //		Stap 11: Toon “niet 0.3”
                Console.WriteLine("Decimal: Niet 0.3");
            }


            Console.WriteLine("\nDruk op enter om verder te gaan.");
            Console.ReadKey();
        }
    }
}
