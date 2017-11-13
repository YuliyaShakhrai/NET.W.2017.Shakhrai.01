using System;
using Sorting;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array1 = new int[100];
            int[] array2 = new int[100];

            Random random = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(1, 1000);
            }

            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = random.Next(1, 1000);
            }

            Console.WriteLine("Array1 before sorting:\n");
            foreach (int a in array1)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Array1 after merge sorting:\n");
            ArraySorting.MergeSort(array1);
            foreach (int a in array1)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Array2 before sorting:\n");
            foreach (int a in array2)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Array2 after quick sorting:\n");
            ArraySorting.QuickSort(array2);
            foreach (int a in array2)
            {
                Console.Write(a + " ");
            }

            Console.ReadKey();
        }
    }
}
