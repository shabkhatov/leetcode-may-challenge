using System;

namespace LeetCode_May_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Day7_Cousins_In_Binary_Tree().IsCousins(new TreeNode(
                1, new TreeNode(2, null, new TreeNode(4)), new TreeNode(3, null, new TreeNode(5)))
            , 5, 4);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
