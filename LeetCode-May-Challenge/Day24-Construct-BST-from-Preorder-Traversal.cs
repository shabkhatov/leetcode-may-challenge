using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day24_Construct_BST_from_Preorder_Traversal
    {  
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public TreeNode BstFromPreorder(int[] preorder)
        {
            if (preorder.Length == 0) return null;
            int[] i = new int[1] { 0 };
            var root = DFS(preorder, i, int.MinValue, int.MaxValue);

            return root;
        }

        private TreeNode DFS(int[] preorder, int[] index, int min, int max)
        {
            if (index[0] >= preorder.Length) {
                return null ;
            };

            TreeNode root = null ;

            int cur_val = preorder[index[0]];
            if (cur_val > min && cur_val < max) {
                root = new TreeNode(cur_val);
                index[0]++;
                root.left = DFS(preorder, index, min, cur_val);
                root.right = DFS(preorder, index, cur_val, max);
            }

                
            return root;
        }
    }
}
