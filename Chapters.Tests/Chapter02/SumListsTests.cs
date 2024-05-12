using System;
using Chapters.Chapter02;
using Shared.LinkedLists;
using Xunit;

namespace Chapters.Tests.Chapter02;

public class SumListsTests
{
    [Theory]
    [InlineData(new byte[] { 7, 1, 6 }, new byte[] { 5, 9, 2 }, new byte[] { 2, 1, 9 })]
    [InlineData(new byte[] { 1 }, new byte[] { 2 }, new byte[] { 3 })]
    [InlineData(new byte[] { 1, 2 }, new byte[] { 2 }, new byte[] { 3, 2 })]
    [InlineData(new byte[] { 5, 5, 2 }, new byte[] { 5, 4 }, new byte[] { 0, 0, 3 })]
    [InlineData(new byte[] { 9, 7, 8 }, new byte[] { 6, 8, 5 }, new byte[] { 5, 6, 4, 1 })]
    [InlineData(new byte[] { 9 }, new byte[] { 1 }, new byte[] { 0, 1 })]
    public void ListSumTest(byte[] a, byte[] b, byte[] result)
    {
        var headA = NodeHelper.FromEnumerable(a);
        var headB = NodeHelper.FromEnumerable(b);
        var expected = NodeHelper.FromEnumerable(result);

        var actual = Solutions.Sum(headA, headB);
        Assert.Equal(NodeHelper.DebugString(expected), NodeHelper.DebugString(actual));
    }
}