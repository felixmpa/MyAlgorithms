using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.AlgoExpert.BinaryTrees
{
    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }
    }

    public class FindClosestValueInBst
    {
        public static int Method1(BST tree, int target)
        {
            int closest = tree.value;
            var queue = new Queue<BST>();
            queue.Enqueue(tree);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current.left != null)
                    queue.Enqueue(current.left);
                if (current.right != null)
                    queue.Enqueue(current.right);

                if (Math.Abs(target - closest) > Math.Abs(target - current.value))
                    closest = current.value;
            }

            return closest;
        }

        /*
		 * RECURSIVE
		 * FindClosestValueInBstRecursive(BST tree, int target)
		 */
        public static int Method2(BST tree, int target)
        {
            return Method2(tree, target, tree.value);
        }

        public static int Method2(BST tree, int target, int closest)
        {
            if (Math.Abs(target - closest) > Math.Abs(target - tree.value))
                closest = tree.value;

            if (target < tree.value && tree.left != null)
            {
                return Method2(tree.left, target, closest);
            }
            else if (target > tree.value && tree.right != null)
            {
                return Method2(tree.right, target, closest);
            }
            else
            {
                return closest;
            }
        }



    }
}
