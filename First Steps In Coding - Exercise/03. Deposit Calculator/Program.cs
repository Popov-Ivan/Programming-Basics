using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int depositsPeriod = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());

            double totalMony = deposit + depositsPeriod * ((deposit * annualInterestRate)/100 / 12);
               
            Console.WriteLine(totalMony);
        }
    }
}
