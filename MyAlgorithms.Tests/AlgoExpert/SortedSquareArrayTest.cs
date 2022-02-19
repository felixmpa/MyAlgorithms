using MyAlgorithms.AlgoExpert;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyAlgorithms.Tests.AlgoExpert
{
    public class SortedSquareArrayTest
    {

        [Theory]
        [MemberData(nameof(Data))]
        public void Method1(int[] arr, int[] expected)
        {
            int[] actual = SortedSquaredArray.Method1(arr);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void Method2(int[] arr, int[] expected)
        {
            int[] actual = SortedSquaredArray.Method2(arr);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { new int[2] { -2, -1}, new int[2] {1, 4} };
            yield return new object[] { new int[1] { -10 }, new int[1] { 100 } };
            yield return new object[] { new int[7] { 1, 2, 3, 5, 6, 8, 9 }, new int[7] {1, 4, 9, 25, 36, 64, 81} };
        }

    }
}
