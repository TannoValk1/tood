using System;

namespace Homework_w14_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sorting();
        }

        static void Sorting()
        {
            int[] numbers = GenerateRandom(10, 0, 1000);
            Console.WriteLine("Unsorted:");
            PrintArray(numbers);
            InsertionSort(numbers);
            Console.WriteLine("Sorted:");
            PrintArray(numbers);
        }

        static int[] GenerateRandom(int size, int min, int max)
        {
            Random rand = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(min, max);
            }
            return array;
        }

        static void InsertionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
