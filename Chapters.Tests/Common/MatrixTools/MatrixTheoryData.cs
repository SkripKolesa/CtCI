using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Chapters.Tests.Common.MatrixTools
{
    public class MatrixTheoryData<T1, T2> : TheoryData<T1, T2>
    {
        public MatrixTheoryData(IEnumerable<T1> data1, IEnumerable<T2> data2)
        {
            var d1 = data1.ToArray();
            var d2 = data2.ToArray();
            for (int i = 0; i < d1.Length; i++)
            {
                Add(d1[i], d2[i]);
            }
        }
    }
}