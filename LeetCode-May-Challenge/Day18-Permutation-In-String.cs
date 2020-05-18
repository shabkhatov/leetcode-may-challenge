using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace LeetCode_May_Challenge
{
    class Day18_Permutation_In_String
    {
        public bool CheckInclusion(string s1, string s2)
        {
            int N = 26;
            int[] letters = new int[N];
            
            foreach (var ch in s1) letters[ch - 'a']++;

            for (int i = 0; i <= s2.Length - s1.Length; i++)
            {
                int[] temp = new int[N];
                for (int l = 0; l < N; l++) temp[l] = letters[l];
                bool f = true;
                for(int j=0; j < s1.Length; j++)
                {
                    var key = s2[i + j] - 'a';
                    temp[key]--;

                    if (temp[key] < 0) {
                        f = false;
                        break;
                    }
                }

                if (f) {
                    for (int j = 0; j < N; j++) {
                        if (temp[j] != 0) {
                            f = false;
                            break;
                        }
                    }

                    if (f) return true;
                }
            }

            return false;
        }
    }
}
