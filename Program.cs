using System;

namespace c_lernen
{

    class Program
    {
        static void Main(string[] args)
        {
            int zahl = Addition(10, 5);
            Console.WriteLine(zahl);
            Console.ReadKey();
        }

        static int Addition(int number1, int number2)
        {
            int ergebnis = number1 + number2;
            return ergebnis;
        }

    }
}
