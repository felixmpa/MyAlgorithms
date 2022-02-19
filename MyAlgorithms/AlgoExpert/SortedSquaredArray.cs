using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.AlgoExpert
{
    public class SortedSquaredArray
    {
        // O(nLogn) time | O(n) space
        public static int[] Method1(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= array[i];
            }
            Array.Sort(array);
            return array;
        }

        // O(n) time | O(n) space
         public static int[] Method2(int[] array)
        {
            int[] sorted_array = new int[array.Length];
            int idxLeft  = 0;
            int idxRight = array.Length - 1;
            
            for(int idx = array.Length - 1; idx >= 0; idx --)
            { 
                int leftValue  = array[idxLeft] * array[idxLeft];
                int rightValue = array[idxRight] * array[idxRight];

                if (leftValue > rightValue)
                {
                    sorted_array[idx] = leftValue;
                    idxLeft++;
                }else {
                    sorted_array[idx] = rightValue;
                    idxRight--;
                }
            }
            return sorted_array;
        }

    }
}
