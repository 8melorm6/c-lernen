using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_lernen
{

    internal class Program
    {

        static void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Wie gehts?");
        }

        static void Main()
        {
            SayHello("Michi");
            SayHello("Mich");
            SayHello("Mic");
            SayHello("Mi");
            SayHello("M");
            SayHello("");

            Console.ReadLine();
        }

    }
}
