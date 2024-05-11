using Xunit;

namespace Chapters.Tests.Common.ToolsTests;

public class ListTesterTests
{
    [Theory]
    [InlineData(new[] { 1, 1, 2, 5, 4, 3 }, 3)]
    public void IsPartitionPositive(int[] input, int pebble)
    {
        
    }

    [Theory]
    [InlineData(new[] { 1, 5, 2, 1, 4, 3 }, 3)]
    public void IsPartitionNegative(int[] input, int pebble)
    {
    }
}