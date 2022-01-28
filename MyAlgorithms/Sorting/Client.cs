using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.Sorting
{
    class Client
    {
        public void Main()
        {
            int[] arr = { 5, 8, 8, 9, 3, 12, 6, 3 };
            Console.WriteLine("Sorting: Bubble Sort {" + String.Join(",", arr) + "}");
            Console.WriteLine("Method1: " + String.Join(",",BubbleSort.Method1(arr)));
            Console.WriteLine("Method1: " + String.Join(",",BubbleSort.Method2(arr)));



        }
    }
}
