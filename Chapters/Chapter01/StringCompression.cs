using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Xsl;

namespace Chapters.Chapter01
{
    /// <summary>
    /// 1.6 String Compression: Implement a method to perform basic string compression using the counts of repeated characters.
    /// For example, the string aabcccccaaa would become a2bc5a3. If the "compressed" string would not become
    /// smaller then the original string, your method should return the original string.
    /// You can assume the string has only uppercase and lowercase letters (a-z).
    /// </summary>
    public static class StringCompression
    {
        public static string Compress(this string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));
            var compressed = new List<(char ch, int n)>();
            var i = 0;
            while (i < str.Length)
            {
                var k = i + 1;
                while (k < str.Length && str[k] == str[i])
                {
                    k++;
                }

                compressed.Add((str[i], k - i));
                i = k;
            }

            return string.Join(string.Empty, compressed.Select(c => c.n > 1 ? $"{c.ch}{c.n}" : $"{c.ch}"));
        }
    }
}