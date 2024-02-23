using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        int num1 = rand.Next(1, 11);

        Console.WriteLine("Arva mis numbrile ma mõtlen vahemikus 1-10?:");
        int guess = Convert.ToInt32(Console.ReadLine());

        if (guess == num1)
        {
            Console.WriteLine("Sa arvasid mu numbri ära!");
        }
        else
        {
            Console.WriteLine($"Sa ei arvanud mu numbrit ära. Õige number oli {num1}.");
        }
    }
}
