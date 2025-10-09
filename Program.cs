using System;

namespace c_lernen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gebe dein Gewicht in kg ein: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Gebe deine Größe in m ein: ");
            double height = Convert.ToDouble(Console.ReadLine()); 

            double bmi = weight / (height * height);
            string classification = "";

            if (bmi < 18.5)
            {
                classification = "Untergewicht";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                classification = "Normalgewicht";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                classification = "Übergewicht";
            }
            else if (bmi >= 30 && bmi < 35)
            {
                classification = "Adipositas Grad 1";
            }
            else if (bmi >= 35 && bmi < 40)
            {
                classification = "Adipositas Grad 2";
            }
            else if (bmi >= 40)
            {
                classification = "Adipositas Grad 3";
            }

            Console.WriteLine();
            Console.WriteLine("Dein BMI beträgt {0}, das ist {1}", bmi, classification);
            Console.ReadKey();

        }
    }
}
