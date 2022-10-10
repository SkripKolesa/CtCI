using System;
using System.Collections.Generic;
using System.Linq;
using Chapters.Chapter01;
using Chapters.Tests.Common.MatrixTools;
using Xunit;

namespace Chapters.Tests.Chapter01
{
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
            Assert.Equal(rotatedA, RotateMatrix.Rotate90(a), new MatrixComparer());
        }
    }
}