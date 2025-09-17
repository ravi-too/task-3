using System;

namespace PasswordCheckApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string correctPassword = "1234"; // სწორი პაროლი
            string input;

            do
            {
                Console.Write("Enter password: ");
                input = Console.ReadLine();
            }
            while (input != correctPassword);

            Console.WriteLine("Correct!");
        }
    }
}
