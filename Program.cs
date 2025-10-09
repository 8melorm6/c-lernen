using System;
using System.Diagnostics.Eventing.Reader;

namespace c_lernen
{
    class Program
    {
        static void Main(string[] args)
        {

            // Weitermachen oder Programm beenden?
            string weitermachen = "ja";

            while (weitermachen.ToLower() != "x")
            {

                // Eingabe 1
                Console.WriteLine("Erste Zahl:");
                string eingabe1 = Console.ReadLine();

                double zahl1 = 0;
                while (!double.TryParse(eingabe1, out zahl1))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte Zahl eingeben:");
                    eingabe1 = Console.ReadLine();
                }

                // Eingabe 2
                Console.WriteLine("Zweite Zahl:");
                string eingabe2 = Console.ReadLine();

                double zahl2 = 0;
                while (!double.TryParse(eingabe2, out zahl2))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte Zahl eingeben:");
                    eingabe2 = Console.ReadLine();
                }

                // Operator
                Console.WriteLine("Rechenart (+, -, *, /):");
                string op = Console.ReadLine();

                double ergebnis = 0;

                /*
                // Berechnung mit if-else
                if (op == "+")
                {
                    ergebnis = zahl1 + zahl2;
                }
                else if (op == "-")
                {
                    ergebnis = zahl1 - zahl2;
                }
                else if (op == "*")
                {
                    ergebnis = zahl1 * zahl2;
                }
                else if (op == "/")
                {
                    if (zahl2 == 0)
                    {
                        Console.WriteLine("Division durch Null ist nicht erlaubt.");
                        continue;
                    }
                    ergebnis = zahl1 / zahl2;
                }
                else
                {
                    Console.WriteLine("Ungültiger Operator.");
                    continue;
                }
                */

                // Berechnung mit switch
                switch (op)
                {
                    case "+":
                        ergebnis = zahl1 + zahl2;
                        break;

                    case "-":
                        ergebnis = zahl1 - zahl2;
                        break;

                    case "*":
                        ergebnis = zahl1 * zahl2;
                        break;

                    case "/":
                        if (zahl2 == 0)
                        {
                            Console.WriteLine("Division durch Null ist nicht erlaubt.");
                            continue;
                        }
                        ergebnis = zahl1 / zahl2;
                        break;

                    default:
                        Console.WriteLine("Ungültiger Operator.");
                        continue;
                }

                // Ausgabe
                Console.WriteLine($"\nErgebnis: {ergebnis}");

                // Entscheidung: weiter oder beenden
                Console.WriteLine("\nMöchtest du weiterrechnen? (beliebige Taste = ja, x = beenden)");
                weitermachen = Console.ReadLine();
                Console.Clear(); // Bildschirm leeren für sauberen Neustart

            }     

        }
    }
}