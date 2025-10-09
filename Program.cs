using System;

namespace c_lernen
{

    class Program
    {
        static void Main(string[] args)
        {
            int age = 14;
            bool withParents = true;

            if (age >= 18)
            {
                Console.WriteLine("Du darfst den Film sehen.");
            }
            else if (withParents == true)
            {
                Console.WriteLine("Du darfst den Film dank deiner Eltern sehen.");
            }
            else
            {
                Console.WriteLine("Du darfst den Film nicht sehen.");
            }

            Console.ReadKey();
        }
    }
}
