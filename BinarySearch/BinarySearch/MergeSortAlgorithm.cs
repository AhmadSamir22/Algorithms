using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public static class MergeSortAlgorithm
    {
        //Complexity O(n log n)
        public static int[] MergeSort(int[] numbers)
        {
            if (numbers.Length == 1)
                return numbers;
            int middle = numbers.Length / 2;
            int[] left = MergeSort(numbers.Take(middle).ToArray());
            int[] right = MergeSort(numbers.Skip(middle).ToArray());

            return Merge(left, right);

        }

        // Complexity O(n)
        static int[] Merge(int[] left, int[] right)
        {
            int l = 0, r = 0, k = 0;
            int[] sortedNumbers = new int[left.Length + right.Length];
            while (k < sortedNumbers.Length)
            {
                if (l >= left.Length)
                {
                    sortedNumbers[k] = right[r];
                    r++;
                    k++;
                }
                else if (r >= right.Length)
                {
                    sortedNumbers[k] = left[l];
                    l++;
                    k++;
                }
                else if (left[l] < right[r])
                {
                    sortedNumbers[k] = left[l];
                    l++;
                    k++;
                }
                else
                {
                    sortedNumbers[k] = right[r];
                    r++;
                    k++;
                }
            }
            return sortedNumbers;

        }
    }
}
