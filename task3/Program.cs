using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("airchie davaleba 1dan 13mde (9is garda): ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            for (int i = 1; i <= 10; i++)
                Console.Write(i + (i < 10 ? " " : ""));
            Console.WriteLine();
        }
        else if (choice == 2)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++) sum += i;
            Console.WriteLine($"Sum = {sum}");
        }
        else if (choice == 3)
        {
            for (int i = 1; i <= 20; i += 2)
                Console.Write(i + (i < 19 ? " " : ""));
            Console.WriteLine();
        }
        else if (choice == 4)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
                Console.WriteLine($"{n} x {i} = {n * i}");
        }
        else if (choice == 5)
        {
            for (int i = 10; i >= 1; i--)
                Console.Write(i + (i > 1 ? " " : ""));
            Console.WriteLine();
        }
        else if (choice == 6)
        {
            Console.Write("Enter n: ");
            int num = int.Parse(Console.ReadLine());
            long fact = 1;
            for (int i = 2; i <= num; i++) fact *= i;
            Console.WriteLine($"Factorial = {fact}");
        }
        else if (choice == 7)
        {
            Console.WriteLine(new string('*', 10));
        }
        else if (choice == 8)
        {
            int s = 0, j = 1;
            while (s < 50) { s += j; j++; }
            Console.WriteLine($"Sum = {s}");
        }
        else if (choice == 12)
        {
            Console.Write("Enter number: ");
            int pal = int.Parse(Console.ReadLine());
            int orig = pal, rev = 0;
            while (pal > 0)
            {
                rev = rev * 10 + pal % 10;
                pal /= 10;
            }
            Console.WriteLine(orig == rev ? "Palindrome" : "Not Palindrome");
        }
        else if (choice == 13)
        {
            Console.Write("Enter n: ");
            int fibN = int.Parse(Console.ReadLine());
            int a = 0, b = 1;
            for (int i = 1; i <= fibN; i++)
            {
                Console.Write(i == 1 ? $"{a}" : " " + a);
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("arastori archevani!");
        }
    }
}
