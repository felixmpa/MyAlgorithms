using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.AlgoExpert.Arrays
{
    class Client
    {
        public void Main()
        {
            //int[] arr = { 3, 5, -4, 8, 11, 1, -1, 6 };
            //int targetSum = 10;
            //Console.WriteLine("TwoNumberSum: " + String.Join(",", TwoNumberSum.Method1(arr, targetSum)));
            //Console.WriteLine("TwoNumberSum: " + String.Join(",", TwoNumberSum.Method2(arr, targetSum)));


            List<int> arr = new List<int>() { 5, 1, 22, 25, 6, -1, 8, 10 };
            List<int> seq = new List<int>() { 1, 6, -1, 10 };
            Console.WriteLine("IsValidSubsequence: " + String.Join(",", IsValidSubsequence.Method1(arr, seq)));
            List<int> arr1 = new List<int>() { 1, 1, 1, 1, 1 };
            List<int> seq1 = new List<int>() { 1, 1, 1 };
            Console.WriteLine("IsValidSubsequence: " + String.Join(",", IsValidSubsequence.Method1(arr1, seq1)));
            
        }
    }
}
