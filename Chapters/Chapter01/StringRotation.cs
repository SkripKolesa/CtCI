﻿using System;

namespace Chapters.Chapter01
{
    /// <summary>
    /// 1.9 String Rotation: Assume you have a method isSubstring which checks if one word is a substring of another.
    /// Given two strings, s1 and s2, write code to check if s2 is a rotation of s1 using only one call to isSubstring.
    /// (e.g., "waterbottle" is a rotation of "erbottlewat").
    /// </summary>
    public static class StringRotation
    {
        public static bool IsRotation(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            var s2doubled = s2 + s2;
            return s2doubled.Contains(s1, StringComparison.Ordinal);
        }
    }
}