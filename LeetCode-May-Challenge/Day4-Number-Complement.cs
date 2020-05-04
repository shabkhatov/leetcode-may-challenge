using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day4_Number_Complement
    {
        public int FindComplement(int num)
        {
            int[] arr = new int[32];
            int size = 0;
            while (num != 0) {
                arr[size] = num % 2;
                num /= 2;
                size++;
            }

            int cnt = 1;
            int result = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == 0) {
                    result += cnt;
                }

                cnt *= 2;
            }

            return result;
        }
    }
}
