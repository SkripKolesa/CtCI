using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chapters.Chapter01
{
    /// <summary>
    /// 1.1 Is Unique: Implement an algorithm to determine if a string has all unique characters.
    /// What if you can't use additional data structures?
    /// </summary>
    public static partial class Solutions
    {
        public static bool HasOnlyUniqueChars(string input,
                                              IsUniqueImplementation implementation = IsUniqueImplementation.HashBased)
        {
            return implementation switch
            {
                IsUniqueImplementation.Naive => Naive(input),
                IsUniqueImplementation.NaiveParallel => NaiveParallel(input),
                IsUniqueImplementation.HashBased => HashBased(input),
                IsUniqueImplementation.BitBased => BitBased(input),
                _ => throw new ArgumentException("Invalid enum value", nameof(implementation))
            };
        }


        private static bool Naive(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j]) return false;
                }
            }

            return true;
        }

        private static bool NaiveParallel(string input)
        {
            bool isAllUnique = true;
            Parallel.For(0, input.Length, (i, state) =>
                                          {
                                              for (int j = i + 1; j < input.Length; j++)
                                              {
                                                  if (input[i] == input[j])
                                                  {
                                                      isAllUnique = false;
                                                      state.Stop();
                                                  }
                                              }
                                          });
            return isAllUnique;
        }

        private static bool HashBased(string input)
        {
            var h = new HashSet<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!h.Add(input[i])) return false;
            }

            return true;
        }

        private static bool BitBased(string input)
        {
            //TODO we only need this extra logic if we don;t know what are chars limitations and need to guess index rnge ourselves
            var codes = new int[input.Length];
            var maxCode = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var code = Convert.ToInt32(input[i]);
                if (code > maxCode)
                {
                    maxCode = code;
                }

                codes[i] = code;
            }

            var v = new BitArray(maxCode + 1);
            foreach (var code in codes)
            {
                if (v[code]) return false;
                v[code] = true;
            }

            return true;
        }
        public enum IsUniqueImplementation
        {
            None = 0,
            Naive,
            NaiveParallel,
            HashBased,
            BitBased
        }
    }

  
}