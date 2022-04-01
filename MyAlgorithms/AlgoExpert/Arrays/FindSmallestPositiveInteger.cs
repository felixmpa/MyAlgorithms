using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.AlgoExpert.Arrays
{
    public class FindSmallestPositiveInteger
    {

        public int Method1(int[] A)
        {
            int smallestInt = 1;

            if (A.Length == 0) return smallestInt;

            Array.Sort(A);

            if (A[0] > 1) return smallestInt;

            if (A[A.Length - 1] <= 0) return smallestInt;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == smallestInt)
                {
                    smallestInt++;
                }
            }

            return smallestInt;
        }

    }
}
