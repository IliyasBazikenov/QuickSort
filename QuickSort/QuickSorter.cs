using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickSort
{
    public class QuickSorter<T> where T: IComparable
    {
        private static IEnumerable<T> empty = new List<T>();
        public static IEnumerable<T> QuickSort(IEnumerable<T> sourceArr) 
        {
            if (sourceArr.Any())
            {
                var pivot = sourceArr.First();
                return QuickSort(sourceArr.Where(e => pivot.CompareTo(e) > 0))
                    .Concat(sourceArr.Where(e => pivot.CompareTo(e) == 0))
                    .Concat(QuickSort(sourceArr.Where(e => pivot.CompareTo(e) < 0)));
            }
            return empty;
        }
    }
}
