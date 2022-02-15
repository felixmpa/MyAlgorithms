using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.AlgoExpert
{
    class Client
    {
        public void Main()
        {
            int[] arr = { 3, 5, -4, 8, 11, 1, -1, 6 };
            int targetSum = 10;
            Console.WriteLine("TwoNumberSum: " + String.Join(",", TwoNumberSum.Method1(arr, targetSum)));
            Console.WriteLine("TwoNumberSum: " + String.Join(",", TwoNumberSum.Method2(arr, targetSum)));



        }
    }
}
