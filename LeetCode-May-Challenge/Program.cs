using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode_May_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Day24_Construct_BST_from_Preorder_Traversal().BstFromPreorder(
                new int[] { 8, 5, 1, 7, 10, 12}
            );
            Console.WriteLine("Result " + result);
            Console.Read();
        }
    }
}
    