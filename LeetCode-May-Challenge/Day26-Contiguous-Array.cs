using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace LeetCode_May_Challenge
{
    class Day26_Contiguous_Array
    {
        public int FindMaxLength(int[] nums)
        {
            int max = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, -1);
            int count = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == 0) count--;
                else count++;

                if (map.ContainsKey(count))
                    max = Math.Max(max, i - map[count]);
                else
                    map.Add(count, i);   
            }

            return max;
        }
    }
}
