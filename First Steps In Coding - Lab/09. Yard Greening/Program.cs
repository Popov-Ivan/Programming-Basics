using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {

            double meters = double.Parse(Console.ReadLine());

            double oneMeterPrice = 7.61;
            double price = oneMeterPrice * meters;
            double priceWithDiscount = 0.18 * price;
            double totalPrice = price - priceWithDiscount;

            Console.WriteLine("The final price is: " + totalPrice);
            Console.WriteLine("The discount is: " + priceWithDiscount);
        }
    }
}
