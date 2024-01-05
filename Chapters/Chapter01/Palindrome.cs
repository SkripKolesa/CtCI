using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapters.Chapter01
{
    /// <summary>
    /// 1.4 Palindrome Permutation: Given a string, write a function to check if it is a permutation of a palindrome.
    /// A palindrome is a word or phrase that is the same towards and backwards. A permutation is a rearrangement
    /// of letters. The palindrome does not need to be limited to just dictionary words.
    /// </summary>
    public static partial class Solutions
    {
        public static bool CanBePalindrome(string input)
        {
            var pairlessItems = new Dictionary<char, bool>();
            foreach (var ch in input.ToLower())
            {
                if (!Char.IsLetterOrDigit(ch)) continue;
                if (pairlessItems.TryGetValue(ch, out var hasPair))
                {
                    pairlessItems[ch] = !hasPair;
                }
                else
                {
                    pairlessItems[ch] = false;
                }
            }

            var nonPairedItemsCount = pairlessItems.Values.Count(p => !p);
            return nonPairedItemsCount <= 1;
        }
    }
}