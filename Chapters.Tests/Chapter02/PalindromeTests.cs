using System;
using Shared.LinkedLists;
using Xunit;

namespace Chapters.Tests.Chapter02;

public class PalindromeTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 2, 1 })]
    public void DetectsPalindromes(int[] input)
    {
        var head = NodeHelper.FromEnumerable(input);
        throw new NotImplementedException();
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3 })]
    public void DetectsNonPalindromes(int[] input)
    {
        var head = NodeHelper.FromEnumerable(input);
        throw new NotImplementedException();
    }
}