using System;

namespace Homework_w14_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawDiamond();
        }

        static void DrawDiamond()
        {
            int number;
            Console.Write("Enter the number of rows: ");
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("Invalid input.");
                Console.Write("Enter the number of rows: ");
            }

            int spaces = number - 1;

            // Upper part of the diamond
            for (int row = 1; row <= number; row++)
            {
                for (int space = 1; space <= spaces; space++)
                {
                    Console.Write(" ");
                }
                spaces--;

                for (int star = 1; star <= 2 * row - 1; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // Lower part of the diamond
            spaces = 1;
            for (int row = number - 1; row >= 1; row--)
            {
                for (int space = 1; space <= spaces; space++)
                {
                    Console.Write(" ");
                }
                spaces++;

                for (int star = 1; star <= 2 * row - 1; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
