using System;

namespace c_lernen
{

    class Program
    {
        static void Main(string[] args)
        {
            int alter = 18;
            bool mobil = false;
            bool qualifiziert = true;
            bool testBestanden = false;
            bool schüchtern = false;

            if ((alter >= 18) && (mobil == true) && (qualifiziert == true || testBestanden == true) && schüchtern == false) 
            {
                Console.WriteLine("Du bekommst den Job!");
            }
            else
            {
                Console.WriteLine("Leider kein Job!");
            }
        }
    }
}
