using System;
using System.Collections.Generic;

namespace Chapters.Tests.Common.MatrixTools
{
    public class MatrixComparer : IEqualityComparer<int[,]>
    {
        public bool Equals(int[,] x, int[,] y)
        {
            CheckDimensions(x, y);
            var n = x.GetLength(0);
            var m = x.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
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

        private void CheckDimensions(int[,] x, int[,] y)
        {
            if (x.GetLength(0) != y.GetLength(0) ||
                x.GetLength(1) != y.GetLength(1))
            {
                throw new ArgumentException("matrices dimensions don't match");
            }
        }
    }
}