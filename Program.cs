using System;

namespace c_lernen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie heißt du?");
            string name = Console.ReadLine();

            int alter; // außerhalb deklarieren, damit nach dem if nutzbar
            while (true)
            {
                Console.WriteLine("Wie alt bist du?");
                string eingabe = Console.ReadLine();

                // Eingabe prüfen
                if (int.TryParse(eingabe, out alter))
                {
                    break; // gültige Zahl → Schleife beenden
                }
                else
                {
                    Console.WriteLine("Bitte gib eine gültige Zahl ein.\n");
                }
            }

            int zukunftsAlter = alter + 10;

            // 3 Wege, String zu formatieren
            Console.WriteLine("Hallo " + name + ", in 10 Jahren bist du " + zukunftsAlter + " Jahre alt."); // Konkatenation
            Console.WriteLine("Hallo {0}, in 10 Jahren bist du {1} Jahre alt.", name, zukunftsAlter);       // Platzhalter
            Console.WriteLine($"Hallo {name}, in 10 Jahren bist du {zukunftsAlter} Jahre alt.");            // Interpolation

            Console.WriteLine("\nProgrammende. Drücke eine Taste zum Beenden...");
            Console.ReadKey();
        }
    }
}