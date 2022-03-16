using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.AlgoExpert.Arrays
{
    public class ArrayOfProducts
    {
        public int[] Method1(int[] array)
        {
            // [5,1,4,2] #array
            // 1*4*2 = 8  idx#0
            // 5*4*2 = 40 idx#1
            // 5*1*2 = 10 idx#2
            // 5*1*4 = 20 idx#3

            //[0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
            //[0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]

            //[0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
            //[362880, 0, 0, 0, 0, 0, 0, 0, 0, 0]

            int currentPosition = 0;
            int idx = 0;
            int totalPosition = array.Length;
            bool walkthrough = true;
            int[] copy = new int[totalPosition];

            while (walkthrough)
            {
                //assign value to ::1
                if (copy[currentPosition] == 0 && currentPosition < totalPosition) { copy[currentPosition] = 1; }

                if (idx != currentPosition && copy[currentPosition] == 0) { copy[currentPosition] = 0; }

                //product of next ::index
                if (idx != currentPosition) { copy[currentPosition] *= array[idx]; } 
                
                idx++;

                //continue with the next position
                if (idx == totalPosition) { currentPosition++; idx = 0; }

                //array of products completed
                if (currentPosition == totalPosition) { walkthrough = false; }
            }

            return copy;
        }




        public int[] Method2(int[] array)
        {

            int[] products = new int[array.Length];

            int leftProduct = 1;
            for(int i =0; i < array.Length; i++)
            {
                products[i] = leftProduct;
                leftProduct *= array[i];
            }

            int rightProduct = 1;
            for(int i=array.Length-1; i >= 0; i--)
            {
                products[i] *= rightProduct;
                rightProduct *= array[i];
            }

            return products;

        }




    }
}
