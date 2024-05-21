using System;

class Program
{
    static void Main(string[] args)
    {
        var stringsList = new List<string>();

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Please enter 3 strings: {i + 1}: ");
            stringsList.Add(Console.ReadLine());
        }

        stringsList.Sort();

        Console.WriteLine("\nResult in sorted list are::");
        foreach (var str in stringsList)
            Console.WriteLine(str);
    }
}
