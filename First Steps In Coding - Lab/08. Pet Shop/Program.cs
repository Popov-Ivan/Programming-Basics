using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int animals = int.Parse(Console.ReadLine());

            double price = dogs * 2.5 + animals * 4.0;
            Console.WriteLine($"{price} lv.");
        }
    }
}
