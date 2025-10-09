using System;

namespace c_lernen
{

    class Program
    {
        static void Main(string[] args)
        {
            int day = 2;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Montag");
                    break;
                case 2:
                    Console.WriteLine("Dienstag");
                    break;
                case 3:
                    Console.WriteLine("Mittwoch");
                    break;
                case 4:
                    Console.WriteLine("Donnerstag");
                    break;
                case 5:
                    Console.WriteLine("Freitag");
                    break;
                case 6:
                    Console.WriteLine("Samstag");
                    break;
                case 7:
                    Console.WriteLine("Sonntag");
                    break;
            }
        }
    }
}
