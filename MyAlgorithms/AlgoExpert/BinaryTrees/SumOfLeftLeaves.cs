using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.AlgoExpert.BinaryTrees
{

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class SumOfLeftLeaves
    {

        public int Method1(TreeNode root)
        {
            int sum = 0;

            if (root != null)
            {

                
               
            }

            return sum;

        }



        public int Method2(TreeNode root)
        {
            int sum = 0;

            if(root != null)
            {
                if (isLeafNode(root.left))
                    sum = sum + root.left.val;
                else
                    sum = sum + Method2(root.left);

                sum = sum + Method2(root.right);
            }
            return sum;
        }

        bool isLeafNode(TreeNode root)
        {
            if (root != null && root.left == null && root.right == null) return true;
            return false;
        }
        
    }
}
