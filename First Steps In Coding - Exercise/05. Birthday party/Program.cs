using System;

namespace _05._Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentForTheHall = double.Parse(Console.ReadLine());

            double priceOfCake = rentForTheHall / 100 * 20;
            double priceForDrink = priceOfCake - (priceOfCake / 100 * 45);
            double priceForAnimator = rentForTheHall / 3;

            double totalPrice = priceOfCake + priceForDrink + priceForAnimator + rentForTheHall;

            Console.WriteLine(totalPrice);
        }
    }
}