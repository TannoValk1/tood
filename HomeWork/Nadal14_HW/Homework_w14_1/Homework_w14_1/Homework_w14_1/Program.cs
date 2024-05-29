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
            int number = GetNumberOfRows();
            DrawUpperPart(number);
            DrawLowerPart(number);
        }

        static int GetNumberOfRows()
        {
            int number;
            Console.Write("Sisesta ridade arv: ");
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("See arv ei sobi!.");
                Console.Write("Sisesta ridade arv: ");
            }
            return number;
        }

        static void DrawUpperPart(int number)
        {
            int spaces = number - 1;

            for (int row = 1; row <= number; row++)
            {
                PrintSpaces(spaces);
                spaces--;
                PrintStars(2 * row - 1);
                Console.WriteLine();
            }
        }

        static void DrawLowerPart(int number)
        {
            int spaces = 1;

            for (int row = number - 1; row >= 1; row--)
            {
                PrintSpaces(spaces);
                spaces++;
                PrintStars(2 * row - 1);
                Console.WriteLine();
            }
        }

        static void PrintSpaces(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(" ");
            }
        }

        static void PrintStars(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
        }
    }
}
