using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day12_Single_Element_In_Sorted_Array
    {
        public int SingleNonDuplicate(int[] nums)
        {
            for (int i = 0; i < nums.Length; i+=2) {
                if (i == nums.Length - 1) return nums[i];
                if (nums[i] != nums[i + 1]) return nums[i];
            }

            return -1;
        }
    }
}
