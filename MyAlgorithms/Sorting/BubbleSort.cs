using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.Sorting
{
    public static class BubbleSort
    {
        public static int[] Method1(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            { 
                for(int j = 0; j < arr.Length - i - 1; j++ )
                {
                    if(arr[j] > arr[j + 1])
                    {
                        int x = arr[j];
                        arr[j]= arr[j + 1];
                        arr[j + 1] = x;
                    }
                }
            }

            return arr;
        }

        public static int[] Method2(int[] arr)
        {
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i< arr.Length - 1; i++)
                {
                    if(arr[i] > arr[i + 1])
                    {
                        //swap
                        int x = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = x;
                        swapped = true;
                    }
                }

            } while (swapped);

            return arr;
        }


    }

}
