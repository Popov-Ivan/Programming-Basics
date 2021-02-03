using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length =int.Parse(Console.ReadLine());
            int width  =int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            int tankVolume = length * width * height;
            double liters = tankVolume * 0.001;
            double realLiters = liters * (1 - (percentage * 0.01));

            Console.WriteLine(realLiters);
        }
    }
}
