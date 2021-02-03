using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfConfectioners = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());

            double priceForCake = 45.0;
            double priceForWaffl = 5.80;
            double priceForPancake = 3.20;

            double profitFromCakes = numberOfCakes * priceForCake;
            double profitFromWaffles = numberOfWaffles * priceForWaffl;
            double profitFromPancakes = numberOfPancakes * priceForPancake;
            double totalAmountForOneDay = (profitFromCakes + profitFromPancakes + profitFromWaffles)*numberOfConfectioners;
            double amountCollectedFromEntireCampaign = totalAmountForOneDay * numberOfDays;
            double finalAmountOfMony = amountCollectedFromEntireCampaign - (amountCollectedFromEntireCampaign / 8);

            Console.WriteLine(finalAmountOfMony);
        }
    }
}
