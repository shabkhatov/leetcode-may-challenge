using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day5_First_Unique_Character_In_String
    {
        public int FirstUniqChar(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int result = -1;

            for (int i = 0; i < s.Length; i++) {
                if (!set.Contains(s[i]))
                {
                    bool firstUniqueIndex = true;
                    for (int j = i + 1; j < s.Length; j++) {
                        if (s[i] == s[j]) {
                            firstUniqueIndex = false;
                            set.Add(s[i]);
                            break;
                        }
                    }
                    if (firstUniqueIndex) {
                        result = i;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
