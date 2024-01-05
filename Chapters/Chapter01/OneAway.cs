using System;

namespace Chapters.Chapter01
{
    /// <summary>
    /// 1.5 One Away: There are three types of edits that can be performed on strings: insert a character, remove a character,
    /// or replace a character. Given two strings, write a function to check if they are one edit (or zero edits) away.
    /// </summary>
    public static partial class Solutions
    {
        public static bool IsOneOrZeroAwayFrom(string a, string b)
        {
            if (a == null) throw new ArgumentNullException(nameof(a));
            if (b == null) throw new ArgumentNullException(nameof(a));
            return IsNoEdit(a, b) ||
                   IsOneInsert(a, b) ||
                   IsOneRemove(a, b) ||
                   IsOneReplace(a, b);
        }

        private static bool IsNoEdit(string a, string b)
        {
            return a.Equals(b);
        }

        private static bool IsOneInsert(string a, string b)
        {
            return b.Length - a.Length == 1 && IsOneChange(a, b);
        }

        private static bool IsOneRemove(string a, string b)
        {
            return IsOneInsert(b, a);
        }

        private static bool IsOneReplace(string a, string b)
        {
            return a.Length == b.Length && HasOneReplace(a, b);
        }

        private static bool HasOneReplace(string a, string b)
        {
            var hasReplace = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i]) continue;
                if (hasReplace) return false;
                hasReplace = true;
            }

            return hasReplace;
        }

        private static bool IsOneChange(string a, string b)
        {
            var i = 0;
            var k = 0;
            while (i < a.Length && k < b.Length)
            {
                if (b[k] != a[i])
                {
                    k++;
                }

                i++;
                k++;
            }

            return i == a.Length;
        }
    }
}