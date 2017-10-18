using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Инициализация массива
            int[] arr = new int[100];
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(1, 1000);
            }
            //Вывод исходного массива в консоль
            Console.WriteLine("Array before sorting:");
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }

            //Проверяем быструю сортировку
            //ArraySorting.QuickSorting(arr, 0, arr.Length - 1);
            //Console.WriteLine("\nArray after quick sorting:");
            //foreach (int a in arr)
            //{
            //    Console.Write(a + " ");
            //}

            //Проверяем сортировку слиянием
            Console.WriteLine("\nArray after merge sorting:");
            foreach (int a in ArraySorting.MergeSorting(arr))
            {
                Console.Write(a + " ");
            }

            Console.ReadKey();
        }
    }
}
