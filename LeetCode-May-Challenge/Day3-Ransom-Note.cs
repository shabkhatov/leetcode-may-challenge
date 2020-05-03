using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day3_Ransom_Note
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var ch in magazine)
            {
                if (dict.ContainsKey(ch)) dict[ch]++;
                else dict.Add(ch, 1);
            }

            foreach (var ch in ransomNote)
            {
                if (!dict.ContainsKey(ch)) return false;
                if (--dict[ch] < 0) return false;
            }

            return true;
        }
    }
}
