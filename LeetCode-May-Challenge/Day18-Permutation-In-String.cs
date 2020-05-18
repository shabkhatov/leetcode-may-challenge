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
            if (s1.Length > s2.Length) return false;
            int N = 26;
            int[] letters1 = new int[N];
            int[] letters2 = new int[N];

            for (int i = 0; i < s1.Length; i++) {
                letters1[s1[i] - 'a']++;
                letters2[s2[i] - 'a']++;
            }

            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (letters2[i] == letters1[i]) count++;
            }


            for (int i = 0; i < s2.Length - s1.Length; i++)
            {
                if (count == N) return true;
                int r = s2[i + s1.Length] - 'a';
                int l = s2[i] - 'a';

                letters2[r]++;
                if (letters2[r] == letters1[r]) count++;
                else if (letters2[r] - 1 == letters1[r]) count--;

                letters2[l]--;
                if (letters1[l] == letters2[l]) count++;
                else if (letters2[l] + 1 == letters1[l]) count--;
            }

            return count == N;
        }
    }
}
