using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.AlgoExpert.Arrays
{
    public class IsValidSubsequence
    {
		public static bool Method1(List<int> array, List<int> sequence)
		{
			List<int> matched = new List<int>();

			foreach(var num in array)
			{
				if (sequence.Contains(num) && matched.Count < sequence.Count)
					matched.Add(num);
			}
			
			bool isValid = false;

			if(matched.Count == sequence.Count)
            {
				for(int i=0; i < matched.Count; i++)
                {
					if(matched[i] != sequence[i])
                    {
						return isValid;
                    }
                }
				return isValid = true;
            }
			return isValid;
		}


		public static bool Method2(List<int> array, List<int> sequence)
		{
			int arrIdx = 0;
			int seqIdx = 0;
			while (arrIdx < array.Count && seqIdx < sequence.Count)
			{
				if (array[arrIdx] == sequence[seqIdx])
					seqIdx++;
				arrIdx++;
			}

			return seqIdx == sequence.Count;
		}
	}
}
