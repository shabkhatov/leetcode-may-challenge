using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Linq;

namespace LeetCode_May_Challenge
{
    class Day22_Sort_Characters_By_Frequency
    {
        public string FrequencySort(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var ch in s) {
                if (dict.ContainsKey(ch)) dict[ch]++;
                else dict.Add(ch, 1);
            }

            var sortedDict = dict.OrderByDescending(x => x.Value);

            StringBuilder sb = new StringBuilder();
            foreach (var pair in sortedDict) {
                for (int i = 0; i < pair.Value; i++) {
                    sb.Append(pair.Key);
                }
            }

            return sb.ToString();
        }
    }
}
