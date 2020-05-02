using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day2_Jewels_and_Stones
    {
        public int NumJewelsInStones(string J, string S)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (var ch in S)
            {
                if (dict.ContainsKey(ch)) dict[ch]++;
                else dict.Add(ch, 1);
            }

            int result = 0;
            foreach (var ch in J)
            {
                if (dict.ContainsKey(ch)) result += dict[ch];
            }

            return result;
        }
    }
}
