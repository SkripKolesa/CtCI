using System;
using System.Collections.Generic;

namespace Chapters.Chapter01
{
    /// <summary>
    /// 1.8 Write an algorithm such that if an element in an MxN matrix is 0, its entire row and column are set to 0
    /// </summary>
    public static partial class Solutions
    {
        public static int[,] ZeroMatrix(int[,] input)
        {
            var result = new int[input.GetLength(0), input.GetLength(1)];
            var zeroCols = new HashSet<int>();
            var zeroRows = new HashSet<int>();
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (input[i, j] == 0)
                    {
                        zeroRows.Add(i);
                        zeroCols.Add(j);
                    }
                }
            }

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (!zeroRows.Contains(i) && !zeroCols.Contains(j))
                    {
                        result[i, j] = input[i, j];
                    }
                }
            }

            return result;
        }
    }
}