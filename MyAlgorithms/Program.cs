using System;
using MyAlgorithms.AlgoExpert.BinaryTrees;

namespace MyAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sorting
            //new MyAlgorithms.Sorting.Client().Main();

            //Arrays
            //new MyAlgorithms.AlgoExpert.Arrays.Client().Main();

            //BinaryTrees
            //
            //     a
            //    / \
            //   b   c
            //  / \   \
            // d   e   f
            //     /
            //    g

            Node a = new Node("a");
            Node b = new Node("b");
            Node c = new Node("c");
            Node d = new Node("d");
            Node e = new Node("e");
            Node f = new Node("f");
            Node g = new Node("g");

            a.left  = b;
            a.right = c;
            b.left  = d;
            b.right = e;
            e.left  = g;
            c.right = f;

            //output: d,b,g,e,a,c,f
            //BinaryTree.TraverseInOrder(a);

            //output: a,b,d,e,g,c,f
            //BinaryTree.TraversePreOrder(a);
            //TraversePreOrder -> Depth First Values
            //Example with Non-recursive way
            //output: a,b,d,e,g,c,f
            //BinaryTree.DepthFirstValues(a);

            //output: a,b,c,d,e,g,f
            //BinaryTree.BreadthFirstValues(a);
            //BinaryTree.TraverseBreadth(a);

            //output: d,g,e,b,f,c,a
            //BinaryTree.TraversePostOrder(a);

        }
    }
}
