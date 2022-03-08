using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.AlgoExpert.BinaryTrees
{

    class Node
    {
        public string data;
        public Node left, right;
        
        public Node(string data)
        {
            this.data = data;
            left = right = null;
        }
    }

    static class BinaryTree
    {
        /* 
         *  Traversal InOrder
         *  
         *  1. First, visit all the nodes in the left subtree
         *  2. Then the root node
         *  3. Visit all the nodes in the right subtree
         *
         *  inorder(root-left)
         *  display(root->data)
         *  inorder(root->right)
        */
        public static void TraverseInOrder(Node node)
        {
            if(node != null)
            {
                TraverseInOrder(node.left);
                Display(node.data);
                TraverseInOrder(node.right);
            }
        }



        /* 
         *  Traversal PreOrder
         *  
         *  1. Visit root node
         *  2. Visit all the nodes in the left subtree
         *  3. Visit all the nodes in the right subtree
         *
         *  display(root->data)
         *  preorder(root->left)
         *  preorder(root->right)
        */
        public static void TraversePreOrder(Node node)
        {
            if (node != null)
            {
                Display(node.data);
                TraversePreOrder(node.left);
                TraversePreOrder(node.right);
            }
        }


        /*
         *  Traversal PostOrder
         * 
         *  1. Visit all the nodes in the left subtree
         *  2. Visit all the nodes in the right subtree
         *  3. visit the root node
         *  
         *  postorder(root->left)
         *  postorder(root->right)
         *  display(root->data)
         */
        public static void TraversePostOrder(Node node)
        {
            if (node != null)
            {
                TraversePostOrder(node.left);
                TraversePostOrder(node.right);
                Display(node.data);
            }
        }


        /*
         * NON-RECURSIVE METHOD
         * Depth First Values
         * 
         *  1. Push in stack the first Node
         *  2. Pop current node and then stack in order subtree 
         *  3. Repeat the same process until traverse pre order
         * 
         */
        public static void DepthFirstValues(Node node)
        {
            var stack = new Stack<Node>();
            stack.Push(node);

            while(stack.Count > 0)
            {
                Node current = stack.Pop();
                Display(current.data);

                if (current.right != null)
                    stack.Push(current.right);

                if (current.left != null)
                    stack.Push(current.left);
            }
        }

        /*
         * NON-RECURSIVE
         * Breadth First Value
         * 
         * 1. Print in order from the parent left to right.
         * 
         */
        public static void BreadthFirstValues(Node node)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                Display(current.data);

                if (current.left != null)
                    queue.Enqueue(current.left);

                if(current.right != null)
                    queue.Enqueue(current.right);
            }
        }



        public static void Display(string txt)
        {
            Console.WriteLine(" " + txt);
        }


    }
}
