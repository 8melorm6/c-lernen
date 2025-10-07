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
            Console.WriteLine("Gebe deinen Vornamen ein: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Gebe deinen Nachnamen ein: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Gebe dein Alter ein: ");
            byte age = Convert.ToByte(Console.ReadLine());
        }
    }
}
