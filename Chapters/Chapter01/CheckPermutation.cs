using System;
using System.Collections.Generic;

namespace Chapters.Chapter01
{
    /// <summary>
    /// 1.2 Check Permutation: Given two strings, write a method to decide if one is a permutation of the other.
    /// </summary>
    public static partial class Solutions
    {
        public static bool IsPermutationOf(string a, string b,
                                           PermutationCheckImplementation implementation = PermutationCheckImplementation.HashBased)
        {
            return implementation switch
            {
                PermutationCheckImplementation.SortBased => SortBased(a, b),
                PermutationCheckImplementation.HashBased => HashBased(a, b),
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

        public enum PermutationCheckImplementation
        {
            None = 0,
            SortBased,
            HashBased
        }
    }
}