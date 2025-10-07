using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_lernen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gebe deinen Vornamen ein: ");
            string firstName = Console.ReadLine();

            Console.Write("Gebe deinen Nachnamen ein: ");
            string lastName = Console.ReadLine();

            Console.Write("Gebe dein Alter ein: ");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Vorname: " + firstName);
            Console.WriteLine("Nachname: " + lastName);
            Console.WriteLine("Alter: " + age);

            Console.WriteLine("Hallo " + firstName + " " + lastName + "! Willkommen zurück!");
            Console.WriteLine("Hallo {0} {1}! Willkommen zurück!", firstName, lastName);
            Console.WriteLine($"Hallo {firstName} {lastName}! Willkommen zurück!");

            Console.ReadKey();
        }
    }
}
