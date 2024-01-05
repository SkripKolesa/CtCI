using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapters.Chapter01
{
    /// <summary>
    /// 1.7 Rotate Matrix: Given an image represented by NxN matrix, where each pixel in the image is 4 bytes,
    /// write a method to rotate the image by 90 degrees. Can you do this in place?
    /// </summary>
    public static partial class Solutions
    {
        public static int[,] Rotate90(int[,] a)
        {
            var n = a.GetLength(0);
            var copy = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    copy[i, j] = a[n - 1 - j, i];
                }
            }

            return copy;
        }
    }
}