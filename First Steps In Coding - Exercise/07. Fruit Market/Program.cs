using System;

namespace _07._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfStrawberries = double.Parse(Console.ReadLine());
            double quantityOfBananas = double.Parse(Console.ReadLine());
            double quantityOfOrange = double.Parse(Console.ReadLine());
            double quantityOfRasberries = double.Parse(Console.ReadLine());
            double quantityOfStrawberries = double.Parse(Console.ReadLine());

            double priceOfRasberries = priceOfStrawberries / 2;
            double priceOfOrange = priceOfRasberries - (priceOfRasberries / 100 * 40);
            double priceOfBananas = priceOfRasberries - (priceOfRasberries / 100 * 80);

            double totalPrice = priceOfBananas*quantityOfBananas + priceOfOrange*quantityOfOrange + priceOfRasberries*quantityOfRasberries + priceOfStrawberries*quantityOfStrawberries;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
