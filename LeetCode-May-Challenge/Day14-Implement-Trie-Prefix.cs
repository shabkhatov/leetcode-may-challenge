using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day14_Implement_Trie_Prefix
    {
        public class TreeNode<T>{
            public ICollection<T> values { get; }
            public TreeNode() {
                values = new List<T>() { };
            }

            public void Insert(T item)
            {
                values.Add(item);
            }
            public bool Search(T item)
            {
                return values.Contains(item);
            }
            public bool SearchPrefix(string itemPrefix)
            {
                return values.Where(x => x.ToString().StartsWith(itemPrefix)).Any();
            }

        }
        public class Trie
        {
            TreeNode<string>[] nodes;
            public Trie()
            {
                nodes = new TreeNode<string>[30];
                for (char i = 'a'; i <= 'z'; i++) {
                    nodes[i - 'a'] = new TreeNode<string>();
                }
            }

            /** Inserts a word into the trie. */
            public void Insert(string word)
            {
                nodes[word[0] - 'a'].Insert(word);
            }

            /** Returns if the word is in the trie. */
            public bool Search(string word)
            {
                return nodes[word[0] - 'a'].Search(word);
            }

            /** Returns if there is any word in the trie that starts with the given prefix. */
            public bool StartsWith(string prefix)
            {
                return nodes[prefix[0] - 'a'].SearchPrefix(prefix);
            }
        }
    }
}
