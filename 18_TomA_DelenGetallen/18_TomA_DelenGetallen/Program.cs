using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_TomA_DelenGetallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 10/11/2026
            // Delen Getallen

            // velden 
            int intDeler = 7 , intDeeltal = 3;
            double doubleDeler = 7, doubleDeeltal = 3;
            decimal decimalDeler = 7m, decimalDeeltal = 3m;

            // programma

            Console.WriteLine("normale deling met / :");

            //Console.WriteLine($"met int deler en deeltal {(intDeeltal / intDeler).ToString()}");
            double uitkomst = intDeeltal / intDeler;
            Console.WriteLine($"met int deler en deeltal {uitkomst.ToString()}");

            Console.WriteLine($"met int deler en double deeltal {(doubleDeeltal / intDeler).ToString()}");
            Console.WriteLine($"met int deler en decimal deeltal {(decimalDeeltal / intDeler).ToString()}");
            
            Console.WriteLine();
            
            Console.WriteLine($"met double deler en int deeltal {(intDeeltal / doubleDeler).ToString()}");
            Console.WriteLine($"met double deler en double deeltal {(doubleDeeltal / doubleDeler).ToString()}");
            // Dit kan niet : Console.WriteLine($"met double deler en decimal deeltal {(decimalDeeltal / doubleDeler).ToString()}");
            Console.WriteLine();
            Console.WriteLine($"met decimal deler en int deeltal {(intDeeltal / decimalDeler).ToString()}");
            // Dit kan niet : Console.WriteLine($"met decimal deler en double deeltal {(doubleDeeltal / decimalDeler).ToString()}");
            Console.WriteLine($"met decimal deler en decimal deeltal {(decimalDeeltal / decimalDeler).ToString()}");

            Console.WriteLine();
            Console.WriteLine($"met getal als deler en int deeltal {(intDeeltal / 7).ToString()}");
            Console.WriteLine($"met getal als deler en double deeltal {(doubleDeeltal / 7).ToString()}");

            Console.WriteLine();
            Console.WriteLine($"met int als deler en getal deeltal {(3 / intDeler).ToString()}");
            Console.WriteLine($"met double als deler en getal deeltal {(3 / doubleDeler).ToString()}");
        }
    }
}
