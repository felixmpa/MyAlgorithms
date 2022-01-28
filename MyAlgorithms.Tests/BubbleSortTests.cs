using System;
using Xunit;
using MyAlgorithms.Sorting;

namespace MyAlgorithms.Tests
{
    public class BubbleSortTests
    {
        [Fact]
        public void Method1()
        {

            int[] arr = new int[new Random().Next(5, 25)];

            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(1, 100);
            }

            int[] actual = BubbleSort.Method1(arr);
            Array.Sort(arr);

            Assert.Equal(arr, actual);
        }

        [Theory]
        [InlineData(new[] { 5, 3, 4}, new[] { 3, 4, 5 })]
        [InlineData(new[] { 1, 4, 5, 3, 4 }, new[] { 1, 3, 4, 4, 5 })]
        [InlineData(new[] { 78, 55, 45, 98, 13 }, new[] { 13, 45, 55, 78, 98 })]
        public void Method2(int[] x, int[] expected)
        {
            int[] actual = BubbleSort.Method2(x);

            Assert.Equal(expected, actual);
        }

    }
}
