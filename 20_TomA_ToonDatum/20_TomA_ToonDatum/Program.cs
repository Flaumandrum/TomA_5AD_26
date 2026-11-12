using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20_TomA_ToonDatum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 12/11/2026
            // Project Toon datum

            // Velden 
            DateTime _datum = default(DateTime), _datum2 = DateTime.MinValue, _datum3 = DateTime.Now;
            bool _herhalen = true;

            // Programma
            
            while(_herhalen)
            {
                Console.Clear();
                Console.WriteLine($"De default DateTime: {_datum.ToString()}");
                Console.WriteLine($"Het minimum DateTime: {_datum2.ToString()}");
                Console.WriteLine($"De huidige DateTime: {DateTime.Now.ToString()}");
                Thread.Sleep(1000);
            }
        }
    }
}
