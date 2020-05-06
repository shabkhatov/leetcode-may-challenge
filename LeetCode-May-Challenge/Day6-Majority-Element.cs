using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day6_Majority_Element
    {
        public int MajorityElement(int[] nums)
        {
            int count = nums.Length / 2;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num)) dict[num]++;
                else dict.Add(num, 1);
            }

            KeyValuePair<int, int> max = new KeyValuePair<int, int>(Int32.MinValue, Int32.MinValue);
            
            foreach (var d in dict) {
                if (d.Value > max.Value) max = d;
            }
            return max.Key;
        }
    }
}
