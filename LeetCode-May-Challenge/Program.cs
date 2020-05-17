using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode_May_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Day17_Find_All_Anagrams_in_string().FindAnagrams(
                "cbaebabacd", "abc"
            );

            Console.WriteLine("Result " + result);
            var iList = result as IEnumerable<int>;
            if (iList != null) {
                foreach (var i in iList) {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
    