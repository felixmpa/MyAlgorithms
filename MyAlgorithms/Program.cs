using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

            /*Node a = new Node("a");
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
            */
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


            //RECURSIVE
            //new MyAlgorithms.AlgoExpert.Recursion.Pyramid().Method1(5);

            //new MyAlgorithms.AlgoExpert.Recursion.Pyramid().Method2(5);

            //new MyAlgorithms.AlgoExpert.Recursion.Pyramid().Method3(5,5);

            //new MyAlgorithms.AlgoExpert.Arrays.ArrayOfProducts().Method2(new int[4] { 5,1,4,2 });
            //new MyAlgorithms.AlgoExpert.Arrays.ArrayOfProducts().Method2(new int[4] { 0,0,0,0 });
            //new MyAlgorithms.AlgoExpert.Arrays.ArrayOfProducts().Method2(new int[11] { 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            /*
            var carInventory = new List<Dictionary<string, string>>();

            var item         = new Dictionary<string, string>();
            
            item.Add("carBrand", "Ford");
            item.Add("carType", "SUV");
            item.Add("numberOfItemsAvailable", "34");

            carInventory.Add(item);

            item  = new Dictionary<string, string>();
            item.Add("carBrand", "Toyota");
            item.Add("carType", "SUV");
            item.Add("numberOfItemsAvailable", "12");

            carInventory.Add(item);

            item = new Dictionary<string, string>();
            item.Add("carBrand", "Ford");
            item.Add("carType", "Sedane");
            item.Add("numberOfItemsAvailable", "3");

            carInventory.Add(item);

            item = new Dictionary<string, string>();
            item.Add("carBrand", "Nissan");
            item.Add("carType", "Sedane");
            item.Add("numberOfItemsAvailable", "10");

            carInventory.Add(item);

            item = new Dictionary<string, string>();
            item.Add("carBrand", "Nissan");
            item.Add("carType", "Convertible");
            item.Add("numberOfItemsAvailable", "8");

            carInventory.Add(item);

            new MyAlgorithms.AlgoExpert.Dictionary.Tabular().Method1(carInventory, "carBrand", "numberOfItemsAvailable");

            new MyAlgorithms.AlgoExpert.Dictionary.Tabular().Method1(carInventory, "carType", "numberOfItemsAvailable");
            */


            /*
             *  3
             *  /\
             * 9 20
             *   /\
             *  15 7 
             *Given the root of binary tree an retrun the sum of all left leaves
             **/
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20, new TreeNode(15), new TreeNode(7));

            //int sum = new MyAlgorithms.AlgoExpert.BinaryTrees.SumOfLeftLeaves().Method1(root);

            //int sum = new MyAlgorithms.AlgoExpert.BinaryTrees.SumOfLeftLeaves().Method2(root);

            /*int[] array = new MyAlgorithms.AlgoExpert.Arrays.TheNextNumSecuencial().Method1(new int[3] {1,2,2} );

            array = new MyAlgorithms.AlgoExpert.Arrays.TheNextNumSecuencial().Method1(new int[5] { 0,1,2,3,0 });

            array = new MyAlgorithms.AlgoExpert.Arrays.TheNextNumSecuencial().Method1(new int[5] { 1, 2, 2, 4, 0 });

            */



        }
    }
}
