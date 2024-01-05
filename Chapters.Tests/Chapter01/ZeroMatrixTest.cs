using System.Collections.Generic;
using Chapters.Chapter01;
using Chapters.Tests.Common.MatrixTools;
using Xunit;

namespace Chapters.Tests.Chapter01
{
    public class ZeroMatrixTest
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
                                                          { 1, 2, 3 },
                                                          { 5, 0, 7 },
                                                          { 8, 9, 10 }
                                                      },
                                                      new int[,]
                                                      {
                                                          { 1, 2, 3 },
                                                          { 5, 0, 7 }
                                                      },
                                                      new int[,]
                                                      {
                                                          { 1, 2, 0 },
                                                          { 5, 0, 7 },
                                                          { 8, 9, 10 }
                                                      },
                                                      new int[,]
                                                      {
                                                          { 0, 0 },
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
                                                           { 1, 2, 3 },
                                                           { 5, 6, 7 },
                                                           { 8, 9, 10 }
                                                       },
                                                       new int[,]
                                                       {
                                                           { 1, 0, 3 },
                                                           { 0, 0, 0 },
                                                           { 8, 0, 10 }
                                                       },
                                                       new int[,]
                                                       {
                                                           { 1, 0, 3 },
                                                           { 0, 0, 0 }
                                                       },
                                                       new int[,]
                                                       {
                                                           { 0, 0, 0 },
                                                           { 0, 0, 0 },
                                                           { 8, 0, 0 }
                                                       },
                                                       new int[,]
                                                       {
                                                           { 0, 0 },
                                                           { 0, 0 }
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
        public void ZeroTest(int[,] a, int[,] zeroedA)
        {
            Assert.Equal(zeroedA, Solutions.ZeroMatrix(a), new MatrixComparer());
        }
    }
}