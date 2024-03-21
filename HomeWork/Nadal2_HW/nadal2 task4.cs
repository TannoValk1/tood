using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        int secretNumber = rand.Next(1, 11);
        int attempts = 0;
        int guess;

        Console.WriteLine("Arva, mis numbrile ma mõtlen vahemikus 1-10?:");

        while (attempts < 3)
        {
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess == secretNumber)
            {
                Console.WriteLine("Sa arvasid mu numbri ära!");
                return;
            }
            else
            {
                Console.WriteLine("Sa ei arvanud mu numbrit ära. Proovi uuesti:");
            }
        }

        Console.WriteLine($"Oled kasutanud kõik kolm katset. Õige number oli {secretNumber}.");
    }
}
