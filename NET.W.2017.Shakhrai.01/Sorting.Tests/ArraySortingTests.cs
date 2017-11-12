using System;
using System.Linq;
using NUnit.Framework;

namespace Sorting.Tests
{
    [TestFixture]
    public class ArraySortingTests
    {
        [Test]
        public void QuickSort_Test()
        {
            int[] array1 = new int[100];
            int[] array2 = new int[100];
            Random random = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(1, 1000);
            }

            array1.CopyTo(array2, 0);

            ArraySorting.QuickSort(array1);
            array2 = array2.OrderBy(x => x).ToArray();
            Assert.AreEqual(array2, array1);
        }

        [Test]
        public void MergeSort_Test()
        {
            int[] array1 = new int[100];
            int[] array2 = new int[100];
            Random random = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(1, 1000);
            }

            array1.CopyTo(array2, 0);

            ArraySorting.MergeSort(array1);
            array2 = array2.OrderBy(x => x).ToArray();
            Assert.AreEqual(array2, array1);
        }
    }
}
