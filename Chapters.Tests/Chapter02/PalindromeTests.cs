using Chapters.Chapter02;
using Shared.LinkedLists;
using Xunit;

namespace Chapters.Tests.Chapter02;

public class PalindromeTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 2, 1 })]
    [InlineData(new[] { 1, 2, 2, 1 })]
    [InlineData(new[] { 1, 2, 3, 3, 2, 1 })]
    [InlineData(new[] { 1, 2, 3, 4, 3, 2, 1 })]
    [InlineData(new[] { 1 })]
    [InlineData(new[] { 1, 1 })]
    public void DetectsPalindromes(int[] input)
    {
        var head = NodeHelper.FromEnumerable(input);
        Assert.True(Solutions.IsPalindrome(head));
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3 })]
    [InlineData(new[] { 1, 2, 2, 0 })]
    [InlineData(new[] { 1, 2, 3, 3, 3, 1 })]
    [InlineData(new[] { 1, 2, 3, 4, 3, 2, 0 })]
    [InlineData(new[] { 1, 2 })]
    public void DetectsNonPalindromes(int[] input)
    {
        var head = NodeHelper.FromEnumerable(input);
        Assert.False(Solutions.IsPalindrome(head));
    }
}