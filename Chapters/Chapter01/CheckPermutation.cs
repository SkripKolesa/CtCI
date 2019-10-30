using System;
using System.Collections.Generic;

namespace Chapters.Chapter01
{
    /// <summary>
    /// 1.2 Given two strings, write a method to decide if one is a permutation of the other.
    /// </summary>
    public static class CheckPermutation
    {
        public static bool IsPermutationOf(this string a, string b,
                                           Implementation implementation = Implementation.HashBased)
        {
            return implementation switch
            {
                Implementation.SortBased => SortBased(a, b),
                Implementation.HashBased => HashBased(a, b),
                _ => throw new ArgumentException("Invalid enum value", nameof(implementation))
            };
        }

        private static bool SortBased(string a, string b)
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

        private static bool HashBased(string a, string b)
        {
            if (b == null) return false;
            if (a.Length != b.Length) return false;
            var stats = new Dictionary<char, int>();
            foreach (var ch in a)
            {
                if (!stats.ContainsKey(ch))
                {
                    stats[ch] = 0;
                }

                stats[ch]++;
            }

            foreach (var ch in b)
            {
                if (!stats.ContainsKey(ch))
                {
                    return false;
                }

                stats[ch]--;
                if (stats[ch] < 0) return false;
            }

            return true;
        }

        public enum Implementation
        {
            None = 0,
            SortBased,
            HashBased
        }
    }
}