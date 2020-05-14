using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day14_Implement_Trie_Prefix
    {
        public class Trie
        {
            IDictionary<char, ICollection<string>> dict;
            /** Initialize your data structure here. */
            public Trie()
            {
                dict = new Dictionary<char, ICollection<string>>();
            }

            /** Inserts a word into the trie. */
            public void Insert(string word)
            {
                if (dict.ContainsKey(word[0]))
                {
                    dict[word[0]].Add(word);
                }
                else dict.Add(word[0], new List<string>() { word});
            }

            /** Returns if the word is in the trie. */
            public bool Search(string word)
            {
                return dict.ContainsKey(word[0]) ? dict[word[0]].Contains(word) : false;
            }

            /** Returns if there is any word in the trie that starts with the given prefix. */
            public bool StartsWith(string prefix)
            {
                return dict.ContainsKey(prefix[0]) ? dict[prefix[0]].Where(x => x.StartsWith(prefix)).Any() : false;
            }
        }
    }
}
