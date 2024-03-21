using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("50% 40st on: " + FindPercentage(40, 50));
        Console.WriteLine("1% 30ns on: " + FindPercentage(30, 1));
    }

    static double FindPercentage(double number, double percentage)
    {
        double result = (number * percentage) / 100;
        return result;
    }
}
