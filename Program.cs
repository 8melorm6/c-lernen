using System;

namespace c_lernen
{

    class Program
    {
        static void Main(string[] args)
        {
            string firstName = GetTextInput("Geben Sie Ihren Vornamen ein: ");
            string lastName = GetTextInput("Geben Sie Ihren Nachnamen ein: ");
            Console.WriteLine($"Hallo, {firstName} {lastName}!");
        }

        static string GetTextInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

    }
}
