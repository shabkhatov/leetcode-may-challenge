using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day17_Find_All_Anagrams_in_string
    {
        int N = 30;
        public IList<int> FindAnagrams(string s, string p)
        {
            IList<int> result = new List<int>();
            int[] arr = new int[N];
            
            foreach (var ch in p) arr[ch - 'a']++;

            for (int i = 0; i <= s.Length - p.Length; i++) {
                if (isAnagram(arr, s, i, p.Length)) result.Add(i);
            }

            return result;
        }

        private bool isAnagram(int[] arr, string s, int i, int length)
        {
            int[] temp = new int[N];
            for (int k = 0; k < N; k++)
            {
                temp[k] = arr[k];
            }

            for (int j = 0; j < length; j++)
            {
                var index = s[i + j] - 'a';
                temp[index]--;
                if (temp[index] < 0)
                {
                    return false;
                }
            }

            for (int k = 0; k < N; k++) {
                if (temp[k] != 0) return false;
            }
            
            return true;
        }
    }
}
