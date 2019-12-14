using System.Collections.Generic;

namespace Chapters.Chapter01
{
    /// <summary>
    /// 1.3 Write a method to replace all spaces in a string with '%20'. You may assume that the string has sufficient
    /// space at the end to hold the additional characters, and that you are given the "true" length of the string.
    /// (Note: Id implementing in Java, please use a character array so that you can perform that operation in place)
    /// </summary>
    public static class URLify
    {
        private static readonly Dictionary<char, string> Replacements = new Dictionary<char, string>
                                                                        {
                                                                            {' ', "%20"}
                                                                        };

        public static void Replace(char[] str, int contentLength)
        {
            var currentContentIdx = contentLength - 1;
            var currentResultIdx = str.Length - 1;
            while (currentContentIdx >= 0)
            {
                var currentChar = str[currentContentIdx];
                if (Replacements.TryGetValue(currentChar, out var replacement))
                {
                    for (int i = replacement.Length - 1; i >= 0; i--)
                    {
                        str[currentResultIdx] = replacement[i];
                        currentResultIdx--;
                    }
                }
                else
                {
                    str[currentResultIdx] = currentChar;
                    currentResultIdx--;
                }

                currentContentIdx--;
            }
        }
    }
}