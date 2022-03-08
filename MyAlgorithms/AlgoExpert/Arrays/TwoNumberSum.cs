using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.AlgoExpert.Arrays
{
	public static class TwoNumberSum
	{
		public static int[] Method1(int[] array, int targetSum)
		{
			List<int> output = new List<int>();

			for (int i = 0; i < array.Length - 1; i++)
			{
				for (int j = i + 1; j < array.Length; j++)
				{
					if ((array[i] + array[j]) == targetSum)
					{
						output.Add(array[i]);
						output.Add(array[j]);
					}
				}
			}

			return output.ToArray();
		}


		public static int[] Method2(int[] array, int targetSum)
		{
			HashSet<int> nums = new HashSet<int>();

			foreach (int num in array)
			{
				int match = targetSum - num;
				if(nums.Contains(match)){
					return new int[] { match, num };
                }else{
					nums.Add(num);
                }
			}

			return new int[0];
		}

	}
}