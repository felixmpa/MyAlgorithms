using MyAlgorithms.AlgoExpert.Arrays;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace MyAlgorithms.Tests.AlgoExpert.Arrays
{
    public class TournamentWinnerTest
    {

        [Theory]
        [MemberData(nameof(Data))]
        public void Method1(List<List<string>> competitions, List<int> results, string expected)
        {
            string actual = TournamentWinner.Method1(competitions, results);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void Method2(List<List<string>> competitions, List<int> results, string expected)
        {
            string actual = TournamentWinner.Method2(competitions, results);

            Assert.Equal(expected, actual);
        }


        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { new List<List<string>> {
                new List<string>{"HTML", "C#"}, 
                new List<string> { "C#", "Python" }, 
                new List<string> { "Python", "HTML" } }, new List<int> { 0, 0, 1 }, "Python" };


            yield return new object[] { new List<List<string>> {
                new List<string> { "HTML", "Java" },
                new List<string> { "Java", "Python" },
                new List<string> { "Python", "HTML" },
                new List<string> { "C#", "Python" },
                new List<string> { "Java", "C#" },
                new List<string> { "C#", "HTML" } }, new List<int> { 0, 1, 1, 1, 0, 1 }, "C#" };



        }

    }
}
