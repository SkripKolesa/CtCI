using System;
using System.Runtime.CompilerServices;

namespace Chapters.Chapter01
{
    /// <summary>
    /// Implement an algorithm to determine if a string has all unique characters.
    /// What if you can't use additional data structures?
    /// </summary>
    public static class IsUnique
    {
        public static bool HasOnlyUniqueChars(this string input,
                                              Implementation implementation = Implementation.Naive)
        {
            return implementation switch
            {
                Implementation.Naive => Naive(input),
                _ => throw new ArgumentException("Invalid enum value", nameof(implementation))
            };
        }


        private static bool Naive(string input)
        {
            throw new NotImplementedException();
        }
    }

    public enum Implementation
    {
        None = 0,
        Naive = 1
    }
}