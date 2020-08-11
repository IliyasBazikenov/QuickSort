using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    public class QuickSorter
    {
        public static void QuickSort(int[] sourceArr, int first, int last) 
        {
            if (first > last || first < 0 || last < 0)
                return ;

            int index = Partition(sourceArr, first, last);
            
            if(index != -1)
            {
                QuickSort(sourceArr, first, index - 1);
                QuickSort(sourceArr, index + 1, last);
            }
        }

        private static int Partition(int[] sourceArr, int first, int last)
        {
            if (first > last)
                return -1;

            int end = first;

            int pivot = sourceArr[last];
            for (int i = first; i < last; i++)
            {
                if(sourceArr[i] < pivot)
                {
                    swap(sourceArr, i, end);
                    end++;
                }
            }

            swap(sourceArr, end, last);
            return end;
        }

        private static void swap(int[] sourceArr, int first, int last)
        {
            int temp = sourceArr[first];
            sourceArr[first] = sourceArr[last];
            sourceArr[last] = temp;
        }
    }
}
