using System;

namespace Chapters.Chapter01
{
    /// <summary>
    /// 1.2 Given two strings, write a method to decide if one is a permutation of the other.
    /// </summary>
    public static class CheckPermutation
    {
        public static bool IsPermutationOf(this string a, string b)
        {
            if (b == null) return false;
            if (a.Length != b.Length) return false;
            var aArr = a.ToCharArray();
            var bArr = b.ToCharArray();
            Array.Sort(aArr);
            Array.Sort(bArr);
            for (int i = 0; i < aArr.Length; i++)
            {
                if (aArr[i] != bArr[i]) return false;
            }

            return true;
        }
    }
}