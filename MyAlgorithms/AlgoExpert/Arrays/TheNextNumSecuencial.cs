using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.AlgoExpert.Arrays
{
    public class TheNextNumSecuencial
    {

        public int[] Method1(int[] array)
        {
            HashSet<int> list = new HashSet<int>();
            
            for(int i=0; i < array.Length; i++)
            {
                if(list.Contains(array[i]) && i > 0)
                    array[i] = array[i - 1] + 1;
                else
                    list.Add(array[i]);
            }

            return array;
        }



        public int[] Method2(int[] array)
        {
            int target = 0;
            int position = 0;
            foreach (var num in array)
            {
                int absNum = Math.Abs(num);
                if (array[absNum - 1] < target)
                {
                    target = absNum;
                    position++;
                }
                array[absNum = 1] *= -1;
            }

            return array;
        }
    }
}

 