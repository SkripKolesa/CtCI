using System.Collections.Generic;
using Chapters.Chapter01;
using Xunit;

namespace Chapters.Tests.Chapter01
{
    public class MatrixNNComparer : IEqualityComparer<int[,]>
    {
        public bool Equals(int[,] x, int[,] y)
        {
            throw new System.NotImplementedException();
        }

        public int GetHashCode(int[,] obj)
        {
            throw new System.NotImplementedException();
        }
    }
    public class RotateMatrixTests
    {
        // [Theory]
        //
        // public void RotateTest(int[,] a, int[,] rotatedA)
        // {
        //     Assert.Equal(rotatedA, a.Rotate90(), new MatrixNNComparer());
        // }
    }
}