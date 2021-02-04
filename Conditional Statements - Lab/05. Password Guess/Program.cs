using System;

namespace _05._Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string logPass = Console.ReadLine();
            string password = "s3cr3t!P@ssw0rd";
           
            if (logPass.Equals(password))
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
