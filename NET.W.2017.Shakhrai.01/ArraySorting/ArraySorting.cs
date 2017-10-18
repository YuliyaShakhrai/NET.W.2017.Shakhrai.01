using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class ArraySorting
    {
        public static void QuickSorting(int[] arr, int first, int last)
        {
            if (arr.Length == 1)
                return;
            int middle = arr[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < middle && i <= last) ++i;
                while (arr[j] > middle && j >= first) --j;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i;
                    --j;
                }
            }
            if (j > first) QuickSorting(arr, first, j);
            if (i < last) QuickSorting(arr, i, last);
        }

        public static int[] MergeSorting(int[] arr)
        {
            if (arr.Length == 1)
                return arr;
            int mid_point = arr.Length / 2;
            return Merge(MergeSorting(arr.Take(mid_point).ToArray()),
                MergeSorting(arr.Skip(mid_point).ToArray()));
        }

        public static int[] Merge(int[] arr1, int[] arr2)
        {
            int a = 0, b = 0;
            int[] result = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length + arr2.Length; i++)
            {
                if (b < arr2.Length && a < arr1.Length)
                    if (arr1[a] > arr2[b])
                        result[i] = arr2[b++];
                    else
                        result[i] = arr1[a++];
                else
                    if (b < arr2.Length)
                    result[i] = arr2[b++];
                else
                    result[i] = arr1[a++];
            }
            return result;
        }
    }
}
