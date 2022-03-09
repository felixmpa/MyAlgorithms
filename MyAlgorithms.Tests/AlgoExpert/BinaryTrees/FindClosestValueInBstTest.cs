using MyAlgorithms.AlgoExpert.BinaryTrees;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyAlgorithms.Tests.AlgoExpert.BinaryTrees
{
    public class FindClosestValueInBstTest
    {

        [Theory]
        [MemberData(nameof(Data))]
        public void Method1(BST tree, int target, int expected)
        {
            int actual = FindClosestValueInBst.Method1(tree, target);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void Method2(BST tree, int target, int expected)
        {
            int actual = FindClosestValueInBst.Method2(tree, target);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> Data()
        {

            /* 
             *tree = 10
             *       /\
             *     5   15
             *    /\   /\
             *   2  5 13 22   
             *  /      \
             * 1        24
             * 
             * target = 12
             * output = 13
             */
            yield return new object[] {                 
                new BST(10) 
                { 
                    left = new BST(5) { 
                        left = new BST(2) {
                           left = new BST(1)
                        }, 
                        right = new BST(5) 
                    },

                    right = new BST(15) {
                        left = new BST(13) {
                            right = new BST(14)
                        },
                        right =  new BST(22)
                    } 
                },
                12,
                13
            };
                


        }

    }
}
