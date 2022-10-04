using System;
using System.Collections.Generic;
using System.Linq;
using Chapters.Chapter01;
using Xunit;

namespace Chapters.Tests.Chapter01
{
    public class MatrixTheoryData<T1, T2> : TheoryData<T1, T2>
    {
        public MatrixTheoryData(IEnumerable<T1> data1, IEnumerable<T2> data2)
        {
            var d1 = data1.ToArray();
            var d2 = data2.ToArray();
            for (int i = 0; i < d1.Length; i++)
            {
                Add(d1[i], d2[i]);
            }
        }
    }

    public class MatrixNNComparer : IEqualityComparer<int[,]>
    {
        public bool Equals(int[,] x, int[,] y)
        {
            var n = x.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (x[i, j] != y[i, j]) return false;
                }
            }

            return true;
        }

        public int GetHashCode(int[,] obj)
        {
            return obj.GetHashCode();
        }
    }


    public class RotateMatrixTests
    {
        public static IEnumerable<int[,]> input = new List<int[,]>()
                                                  {
                                                      new int[,]
                                                      {
                                                          { 1, 2, 3 },
                                                          { 5, 6, 7 },
                                                          { 8, 9, 10 }
                                                      },
                                                      new int[,]
                                                      {
                                                          { 1, 2 },
                                                          { 3, 4 }
                                                      },
                                                      new int[,]
                                                      { },
                                                      new int[,]
                                                      {
                                                          { 1 }
                                                      }
                                                  };

        public static IEnumerable<int[,]> output = new List<int[,]>()
                                                   {
                                                       new int[,]
                                                       {
                                                           { 8, 5, 1 },
                                                           { 9, 6, 2 },
                                                           { 10, 7, 3 }
                                                       },
                                                       new int[,]
                                                       {
                                                           { 3, 1 },
                                                           { 4, 2 }
                                                       },
                                                       new int[,]
                                                       { },
                                                       new int[,]
                                                       {
                                                           { 1 }
                                                       }
                                                   };

        public static MatrixTheoryData<int[,], int[,]> MatrixData = new MatrixTheoryData<int[,], int[,]>(input, output);

        [Theory]
        [MemberData(nameof(MatrixData))]
        public void RotateTest(int[,] a, int[,] rotatedA)
        {
            Assert.Equal(rotatedA, RotateMatrix.Rotate90(a), new MatrixNNComparer());
        }
    }
}