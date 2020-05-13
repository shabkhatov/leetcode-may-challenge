using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day13_Remove_K_Digits
    {
        public string RemoveKdigits(string num, int k)
        {
            StringBuilder sb = new StringBuilder(num);
            int i = 0;
            if (sb.Length == k) return "0";
            while (k > 0 && sb.Length > 0) {
                if (sb[i] == '0') { sb.Remove(i, 1); continue; }
                if (sb[i] <= sb[i + 1])
                {
                    int j = i + 1;
                    while(j < sb.Length-1 && sb[j+1] >= sb[j])
                    {
                        j++;
                    }
                    sb.Remove(j, 1);
                }
                else sb.Remove(i, 1);
                k--;
            }
            while (sb.Length > 0 && sb[0] == '0') sb.Remove(0, 1);

            return sb.Length > 0 ? sb.ToString() : "0";
        }
    }
}
