using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MyAlgorithms.AlgoExpert;

namespace MyAlgorithms.Tests.AlgoExpert
{
    public class IsValidSubsequenceTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void Method1(List<int> arr, List<int> seq, bool expected)
        {
            bool actual = IsValidSubsequence.Method1(arr, seq);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void Method2(List<int> arr, List<int> seq, bool expected)
        {
            bool actual = IsValidSubsequence.Method2(arr, seq);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[] {new List<int>() { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int>() { 1, 6, -1, 10 }, true };
            yield return new object[] {new List<int>() { 1, 1, 1, 1, 1 }, new List<int>() { 1, 1, 1 }, true };
        }

    }
}
