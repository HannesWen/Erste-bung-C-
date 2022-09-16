using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Uebungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Einträge möchtest du in deinem int Array?");

            int arraygröße = Convert.ToInt16(Console.ReadLine());
            int[] zahlen = new int [arraygröße] ;

            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine("Gebe mir eine Zahl für das Array!");
                zahlen[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("[ ");
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.Write($" {zahlen[i]} | ");
            }
            Console.WriteLine("] ");

            double durchschnitt = zahlen.Average();
            int maximalwert = zahlen.Max();
            int minimalwert = zahlen.Min();
            Console.WriteLine("Der Durchschnitt ist: " + durchschnitt);
            Console.WriteLine("Der Minimalwert ist: " + minimalwert);
            Console.WriteLine("Der Maximalwert ist: " + maximalwert);
            Console.ReadKey();



        }
    }
}
