using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 1: 

            //int zahl1 = 1;
            //int zahl2 = 2;
            //Console.WriteLine(zahl1 + zahl2);
            //Console.ReadLine();

            //Aufgabe 2: 

            Console.WriteLine("Welche Zahlen möchtest du Addieren? ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            int summe = zahl1 + zahl2;
            Console.WriteLine("Die Summe deiner Zahlen ist: " + summe);
            Console.ReadLine();

        }
    }
}
