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
            //Console.WriteLine("Welche Zahlen möchtest du Addieren? ");
            //int zahl1 = Convert.ToInt32(Console.ReadLine());
            //int zahl2 = Convert.ToInt32(Console.ReadLine());
            //int summe = zahl1 + zahl2;
            //Console.WriteLine("Die Summe deiner Zahlen ist: " + summe);
            //Console.ReadLine();

            //Aufgabe 3: 
            //Console.WriteLine("Gib mir bitte einen Text");
            //string entry = Console.ReadLine();
            //string replaced_entry = entry.Replace("U", "u").Replace("G", "g");
            //Console.WriteLine(replaced_entry);    
            //Console.ReadLine();

            //Aufgabe 4:
            //Console.WriteLine("Wie lautet dein Wunschtext?");
            //string textlänge = Console.ReadLine();
            //Console.WriteLine("Die länge deines textes ist: " + textlänge.Length);
            //Console.ReadLine();

            //Aufgabe 2b:
            //Console.WriteLine("Bitte gebe mir 2 Zahlen mit Kommastelle");
            //double zahl1 = Convert.ToDouble(Console.ReadLine());
            //double zahl2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(zahl1 + zahl2);
            //Console.ReadLine();

            //Aufgabe 5:
            //Console.WriteLine("Gib mir bitte einen Text!");
            //string text = Console.ReadLine();
            //Console.WriteLine(text.PadLeft(20, 'y'));
            //Console.ReadLine();

            //Aufgabe 6:
            //Console.WriteLine("Gib mir bitte einen Text!");
            //string text = Console.ReadLine();
            //Console.WriteLine(text.PadRight(30, 'y'));
            //Console.ReadLine();

            //Aufgabe 7:
            //Console.WriteLine("Bitte gebe mir eine Texteingabe mit einigen Leerzeichen davor und danach, Danke!");
            //string text = Console.ReadLine();
            //Console.WriteLine(text);
            //Console.WriteLine(text.Trim());
            //Console.ReadLine();

            //Aufgabe 8:
            Console.WriteLine("Bitte gib mir einen Text mit ; Danke");
            string text = Console.ReadLine();
            string[] newText = text.Split(';');
            foreach (var word in newText)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}
