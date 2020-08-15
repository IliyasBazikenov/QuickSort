using NUnit.Framework;
using QuickSort;
using System;
using System.Collections.Generic;

namespace TestQuickSort
{
    [TestFixture]
    public class QuickSorterTest
    {
        [Test]
        public void QuickSort()
        {
            var testArr1 = new List<int>(new int[] { 4, 1, 3, 7, 4, 6, 2, 7 });
            var expectedArr1 = QuickSorter<int>.QuickSort(testArr1);
            Assert.That(testArr1, Is.EquivalentTo(expectedArr1));

            var testArr2 = new List<int>(new int[]{ 1, 5, 3, 9, 9, 3, 3, 7, 2, 7, 5, 6, 9, 8, 458, 32, 56, 7 });
            var expectedArr2 = QuickSorter<int>.QuickSort(testArr2);
            Assert.That(testArr2, Is.EquivalentTo(expectedArr2));
        }
    }
}