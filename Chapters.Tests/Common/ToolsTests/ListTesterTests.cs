using Chapters.Tests.Common.LinkedListTools;
using Shared.LinkedLists;
using Xunit;

namespace Chapters.Tests.Common.ToolsTests;

public class ListTesterTests
{
    [Theory]
    [InlineData(new[] { 1, 1, 2, 5, 4, 3 }, 3)]
    [InlineData(new[] { 3, 1, 2, 10, 5, 5, 8 }, 5)]
    [InlineData(new[] { 1, 2, 4, 5 }, 3)]
    [InlineData(new[] { 1, 2, 5, 4 }, 3)]
    [InlineData(new[] { 1 }, 2)]
    [InlineData(new[] { 1, 1, 1, 1, 1 }, 2)]
    [InlineData(new[] { 1, 1, 1, 1, 2 }, 2)]
    [InlineData(new[] { 1, 1, 1, 1, 1 }, 1)]
    [InlineData(new[] { 1, 1, 1, 1, 1 }, 0)]
    [InlineData(new[] { 1, 1, 1, 2, 2 }, 2)]
    public void IsPartitionPositive(int[] input, int pebble)
    {
        var tester = new ListTester<int>(NodeHelper.FromEnumerable(input), new ListTester<int>.Options
                                                                           {
                                                                               Pebble = pebble
                                                                           });
        Assert.True(tester.IsPartitioned());
    }

    [Theory]
    [InlineData(new[] { 1, 5, 2, 1, 4, 3 }, 3)]
    [InlineData(new[] { 1, 5, 4, 2 }, 3)]
    [InlineData(new[] { 1, 2, 1, 1, 1 }, 2)]
    [InlineData(new[] { 1, 1, 1, 1, 0 }, 1)]
    [InlineData(new[] { 1, 1, 0, 1, 1 }, 1)]
    [InlineData(new[] { 2, 1, 1, 1, 2 }, 2)]
    [InlineData(new[] { 2, 1, 1, 1, 1 }, 2)]
    public void IsPartitionNegative(int[] input, int pebble)
    {
        var tester = new ListTester<int>(NodeHelper.FromEnumerable(input), new ListTester<int>.Options
                                                                           {
                                                                               Pebble = pebble
                                                                           });
        Assert.False(tester.IsPartitioned());
    }
}