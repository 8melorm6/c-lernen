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
            Console.Write("Gebe Zahl1 ein: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Gebe Zahl2 ein: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
            Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
            Console.WriteLine("{0} * {1} = {2}", number1, number2, number1 * number2);
            Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);
            Console.WriteLine("{0} % {1} = {2}", number1, number2, number1 % number2);

            Console.ReadKey();
        }
    }
}
