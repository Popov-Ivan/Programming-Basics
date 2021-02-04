using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type.Equals("square"))
            {
                double s = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(s * s, 3));
            }
            else if (type.Equals("rectangle"))
            {
                double s1 = double.Parse(Console.ReadLine());
                double s2 = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(s1 * s2, 3));
            }
            else if (type.Equals("circle"))
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI * r * r, 3));
            }
            else if (type.Equals("triangle"))
            {
                double sBase = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((h * sBase) / 2, 3));
            }
        }
    }
}
