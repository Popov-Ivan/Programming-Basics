using System;

namespace _04._Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            double numberOfDays = double.Parse(Console.ReadLine());

            double timeInHours = (numberOfPages / pagesPerHour) / numberOfDays;

            Console.WriteLine(timeInHours);
        }
    }
}
