using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;
using System.Xml.Serialization;

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
            //Console.WriteLine("Bitte gib mir einen Text mit ; Danke");
            //string text = Console.ReadLine();
            //string[] newText = text.Split(';');
            //foreach (var word in newText)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.ReadLine();

            //Aufgabe 9:
            //Console.WriteLine("Bitte gib mir einen Text deiner Wahl");
            //string text = Console.ReadLine();
            //Console.WriteLine(text.Contains("abc"));
            //Console.ReadLine();

            //if (text.Contains("abc"))
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //    Console.WriteLine("false");

            //Aufgabe 10:
            //Console.WriteLine("bitte gib mir einen text deiner wahl");
            //string text = Console.ReadLine();
            //Console.WriteLine(text.ToUpper());
            //Console.ReadLine();

            //Seite 2, Aufgabe 1
            //Console.WriteLine("Gib mir bitte eine Zahl");
            //int zahl = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int zahl1 = 0; zahl > sum; zahl1++)
            //{
            //    sum = sum + zahl1;
            //    Console.WriteLine(sum);
            //}
            //Console.ReadLine();

            //Seite 2, Aufgabe 2
            //Console.WriteLine("Gib mir bitte eine Zahl");
            //int zahl = Convert.ToInt32(Console.ReadLine());
            //for (int zahl1 = zahl; zahl1 >= 0; zahl1--)
            //{
            //    Console.WriteLine(zahl1);
            //}
            //Console.ReadLine();


            //Seite 2, Aufgabe 3:
            //Console.WriteLine("Enter a search value");
            //string searchValue = Console.ReadLine();

            //string namen = "Jonas Bundschuh, Philipp Ehringer ,Niklas Gottermann , Marcello Greulich ,  Andreas Litt ,  Robin Mohr ,  Robert Pfeilmayer ,  Marie Scholz ,  Leon Schuster ,  Erwin Schäberle ,  Jan Throm ,  Mona Walter ,  lukas Welker ,  Johannes Wengert";
            //string[] list = namen.Split(',');

            //for (int i = 0; i < list.Length; i++)
            //{
            //    if (list[i].Contains(searchValue))
            //    {
            //        Console.WriteLine(list[i].Trim());
            //    }
            //}
            //Console.ReadKey();


            //Zusatzaufgabe
            //Lasse eine Zahl zwischen 1 und 100 generieren.
            //Der Nutzer bekommt hinweise ob die Zahl höher oder tiefer liegt. 

            //Random r = new Random();
            //int random_zahl = r.Next(1, 100);
            ////Console.WriteLine(random_zahl);
            //int gesuchte_zahl = 0;
            //Console.WriteLine("Wir suchen eine zahl zwischen 1 und 100, welche ist es?");
            //do
            //{
            //    gesuchte_zahl = Convert.ToInt32(Console.ReadLine());
            //    if (gesuchte_zahl == 42 && random_zahl == 42)
            //    {
            //        Console.WriteLine("Deine Antwort ist doppelt richtig!"); 
            //    }
            //    else if (gesuchte_zahl == 42)
            //    {
            //        Console.WriteLine("Deine Antwort ist richtig aber wir suchen eine andere Zahl, versuchs weiter!");
            //    }
            //    else if (gesuchte_zahl < random_zahl)
            //    {
            //        Console.WriteLine("Die gesuchte Zahl ist größer");
            //    }
            //    else if (gesuchte_zahl > random_zahl)
            //    {
            //        Console.WriteLine("Die gesuchte Zahl ist kleiner");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Glückwunsch, du hast die richtige Zahl erraten!");
            //    }
            //} while (gesuchte_zahl != random_zahl);
            //Console.ReadKey();


            // Wie funktionieren Arrays? 

            int[] zahlen = new int[5];
            //[   |   |   |   |   ]
            //int[] zahlen2 = new int[] { 2, 8, 12, 3, 6 };
            //[ 2 | 8 | 12 | 3 | 6 ]

            for(int i = 0; i< zahlen.Length; i++)
            {
                Console.WriteLine("Gebe mir eine Zahl für das Array!");
                zahlen[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("[ ");
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.Write($" {zahlen[i]} | ");
            }
            Console.Write("] ");
            Console.ReadKey();

        }
    }
}
