namespace Sorting
{
    public class ArraySorting
    {
        public static void QuickSort(int[] array)
        {
            int first = 0;
            int last = array.Length - 1;
            QuickSort(array, first, last);
        }

        public static void QuickSort(int[] array, int first, int last)
        {
            if (array.Length == 1)
            {
                return;
            }

            int middle = array[((last - first) / 2) + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (array[i] < middle && i <= last)
                {
                    ++i;
                }

                while (array[j] > middle && j >= first)
                {
                    --j;
                }

                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    ++i;
                    --j;
                }
            }

            if (j > first)
            {
                QuickSort(array, first, j);
            }

            if (i < last)
            {
                QuickSort(array, i, last);
            }
        }

        public static void MergeSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergeSort(array, low, middle);
                MergeSort(array, middle + 1, high);
                Merge(array, low, middle, high);
            }
        }

        public static void MergeSort(int[] array)
        {
            MergeSort(array, 0, array.Length - 1);
        }

        private static void Merge(int[] array, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;
            int[] temp = new int[(high - low) + 1];
            int tempIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (array[left] < array[right])
                {
                    temp[tempIndex] = array[left];
                    left = left + 1;
                }
                else
                {
                    temp[tempIndex] = array[right];
                    right = right + 1;
                }

                tempIndex = tempIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    temp[tempIndex] = array[left];
                    left = left + 1;
                    tempIndex = tempIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    temp[tempIndex] = array[right];
                    right = right + 1;
                    tempIndex = tempIndex + 1;
                }
            }

            for (int i = 0; i < temp.Length; i++)
            {
                array[low + i] = temp[i];
            }
        }
    }
}
