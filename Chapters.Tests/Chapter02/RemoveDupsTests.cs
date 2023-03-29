using System.Collections.Generic;
using Chapters.Chapter02;
using Chapters.Tests.Common.LinkedListTools;
using Shared.LinkedLists;
using Xunit;

namespace Chapters.Tests.Chapter02;

public class RemoveDupsTests
{
    private static readonly List<int[]> _inputs = new List<int[]>
                                                  {
                                                      new[]
                                                      {
                                                          1, 2, 2, 1
                                                      },
                                                      new[]
                                                      {
                                                          1
                                                      },
                                                      new[]
                                                      {
                                                          1,2
                                                      },
                                                      new[]
                                                      {
                                                          1,1
                                                      },
                                                      new[]
                                                      {
                                                          1,1,1
                                                      },
                                                      new[]
                                                      {
                                                          1,2,3,2,4
                                                      }
                                                  };
    private static readonly List<int[]> _outputs = new List<int[]>
                                                  {
                                                      new[]
                                                      {
                                                          1, 2
                                                      },
                                                      new[]
                                                      {
                                                          1
                                                      },
                                                      new[]
                                                      {
                                                          1,2
                                                      },
                                                      new[]
                                                      {
                                                          1
                                                      },
                                                      new[]
                                                      {
                                                          1
                                                      },
                                                      new[]
                                                      {
                                                          1,2,3,4
                                                      }
                                                  };

    public static readonly LinkedListTheoryData _data = new LinkedListTheoryData(_inputs, _outputs);

    [Theory]
    [MemberData(nameof(_data))]
    public void RemoveDuplicates(LinkedListik list, string expected)
    {
        var clearedList = list.RemoveDuplicates();
        Assert.Equal(expected, clearedList.ToString());
    }
}