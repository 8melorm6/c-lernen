using System;
using System.Collections.Generic; // Für die List<> benötigt

namespace c_lernen
{
    class Program
    {
        static void Main(string[] args)
        {
            string weitermachen = "ja";
            List<string> historie = new List<string>(); // speichert alle Rechnungen

            while (weitermachen.ToLower() != "x")
            {
                Console.WriteLine("\n========================================");
                Console.WriteLine("Mini-Rechner");
                Console.WriteLine("========================================\n");

                // Erste Zahl
                Console.WriteLine("--- Erste Zahl ---");
                Console.Write("Eingabe (Komma als Dezimalzeichen, z. B. 3,14): ");
                string eingabe1 = Console.ReadLine();
                eingabe1 = eingabe1.Replace('.', ',');

                double zahl1 = 0;
                while (!double.TryParse(eingabe1, out zahl1))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fehler: ungültige Eingabe!");
                    Console.ResetColor();
                    Console.Write("Bitte Zahl erneut eingeben: ");
                    eingabe1 = Console.ReadLine();
                    eingabe1 = eingabe1.Replace('.', ',');
                }

                // Zweite Zahl
                Console.WriteLine("\n--- Zweite Zahl ---");
                Console.Write("Eingabe (Komma als Dezimalzeichen, z. B. 3,14): ");
                string eingabe2 = Console.ReadLine();
                eingabe2 = eingabe2.Replace('.', ',');

                double zahl2 = 0;
                while (!double.TryParse(eingabe2, out zahl2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fehler: ungültige Eingabe!");
                    Console.ResetColor();
                    Console.Write("Bitte Zahl erneut eingeben: ");
                    eingabe2 = Console.ReadLine();
                    eingabe2 = eingabe2.Replace('.', ',');
                }

                // Operator
                Console.WriteLine("\n--- Rechenart ---");
                Console.Write("Wähle (+, -, *, /): ");
                string op = Console.ReadLine();

                double ergebnis = 0;

                // Berechnung
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
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fehler: Division durch Null nicht erlaubt!");
                            Console.ResetColor();
                            continue;
                        }
                        ergebnis = zahl1 / zahl2;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fehler: Ungültiger Operator!");
                        Console.ResetColor();
                        continue;
                }

                // Ausgabe
                string rechnung = $"{zahl1} {op} {zahl2} = {ergebnis:F2}";
                Console.WriteLine($"\nRechnung: {rechnung}");

                // In Historie speichern
                historie.Add(rechnung);

                // Entscheidung: weiter oder beenden
                Console.WriteLine("\nMöchtest du weiterrechnen? (beliebige Taste = ja, x = beenden)");
                weitermachen = Console.ReadLine();
                Console.Clear();
            }

            // Nach Programmende Historie anzeigen
            Console.WriteLine("Programm beendet.\n");
            Console.WriteLine("Berechnungen dieser Sitzung:");
            Console.WriteLine("----------------------------------------");

            if (historie.Count == 0)
            {
                Console.WriteLine("Keine Berechnungen durchgeführt.");
            }
            else
            {
                foreach (string eintrag in historie)
                {
                    Console.WriteLine(eintrag);
                }
            }

            Console.WriteLine("\nDrücke eine Taste zum Schließen...");
            Console.ReadKey();
        }
    }
}
