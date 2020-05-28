using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day28_Counting_Bits
    {
        public int[] CountBits(int num)
        {
            int[] bits = new int[num + 1];
            if (num <= 3) {
                for (int i = 0; i <= num; i++) {
                    if (i >= 2) bits[i] = i - 1;
                    else bits[i] = i;
                }
                return bits;
            } 
            bits[0] = 0;
            bits[1] = 1;
            bits[2] = 1;
            bits[3] = 2;

            int left = 0;
            for (int i = 4; i <= num; i++) {
                if (isPowerOfTwo(i)) {
                    left = 0;
                }
                bits[i] = bits[left] + 1;
                left++;
            }

            return bits;
        }
        static bool isPowerOfTwo(int x)
        {
            return x != 0 && ((x & (x - 1)) == 0);
        }
    }
}
