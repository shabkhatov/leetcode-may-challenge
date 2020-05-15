using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day15_Max_Sum_Circular_Subarray
    {
        public int MaxSubarraySumCircular(int[] A)
        {
            int max = findMaxSum(A);

            int min = findMinSum(A);

            int total = 0;
            foreach (var i in A) total += i;

            return total == min ? max : Math.Max(max, total - min);
        }

        private int findMinSum(int[] arr)
        {
            int result = arr[0];
            var current_min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                current_min = Math.Min(current_min, 0) + arr[i];

                if (current_min < result) result = current_min;
            }

            return result;
        }

        private int findMaxSum(int[] arr)
        {
            int result = arr[0];
            var current_max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                current_max = Math.Max(current_max, 0) + arr[i];

                if (current_max > result) result = current_max;
            }

            return result;
        }
    }
}
