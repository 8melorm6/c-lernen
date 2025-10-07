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
            SayHello("Max", 25);
            SayHello("Anna", 30);

            Console.ReadKey();
        }

        static void SayHello(string name, int age)
        {
            Console.WriteLine("Hallo {0}, du bist {1} Jahre alt!", name, age);
        }

    }
}
