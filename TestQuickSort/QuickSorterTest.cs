using NUnit.Framework;
using QuickSort;

namespace TestQuickSort
{
    [TestFixture]
    public class QuickSorterTest
    {
        [Test]
        public void QuickSort()
        {
            var testArr1 = new int[] { 4, 1, 3, 7, 4, 6, 2, 7 };
            var expectedArr1 = new int[] { 1, 2, 3, 4, 4, 6, 7, 7 };

            var testArr2 = new int[] { 1, 5, 3, 9, 9, 3, 3, 7, 2, 7, 5, 6, 9, 8, 458, 32, 56, 7 };
            var expectedArr2 = new int[] { 1, 2, 3, 3, 3, 5, 5, 6, 7, 7, 7, 8, 9, 9, 9, 32, 56, 458 };

            QuickSorter.QuickSort(testArr1, 0, testArr1.Length - 1);
            Assert.That(testArr1, Is.EquivalentTo(expectedArr1));

            QuickSorter.QuickSort(testArr2, 0, testArr2.Length - 1);
            Assert.That(testArr2, Is.EquivalentTo(expectedArr2));
        }
    }
}