using System;

namespace Homework_w14_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = GenerateRandomArray(10, 0, 1000);
            
            Console.WriteLine("Unsorted:");
            PrintArray(numbers);
            
            InsertionSort(numbers);
            
            Console.WriteLine("Sorted:");
            PrintArray(numbers);
        }

        static int[] GenerateRandomArray(int size, int min, int max)
        {
            var random = new Random();
            var array = new int[size];
            
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(min, max);
            }
            
            return array;
        }

        static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var key = array[i];
                int j = i - 1;
                
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                
                array[j + 1] = key;
            }
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
