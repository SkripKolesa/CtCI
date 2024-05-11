using System.Linq;
using Chapters.Chapter02;
using Chapters.Tests.Common.LinkedListTools;
using Shared.LinkedLists;
using Xunit;

namespace Chapters.Tests.Chapter02;

public class PartitionTests
{
    [Theory]
    [InlineData(new[] { 3, 1, 2, 5, 4 }, 3)]
    public void Partitions(int[] input, int pebble)
    {
        var head = NodeHelper.FromEnumerable(input);

        var partitioned = Solutions.Partition(head, pebble);

        var asserter = new ListTester<int>(partitioned, new ListTester<int>.Options { Pebble = pebble });
        Assert.True(asserter.IsPartitioned(), asserter.UserMessage);
    }
}