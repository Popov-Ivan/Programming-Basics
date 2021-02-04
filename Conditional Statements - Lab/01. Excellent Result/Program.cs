using System;

namespace _01._Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            string mesage = "";
            double grade = double.Parse(Console.ReadLine());
            if (grade>=5.5)
            {
                mesage = "Excellent!";
            }            
            Console.WriteLine(mesage);
        }
    }
}
