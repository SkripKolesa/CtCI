using System;
using Chapters.Chapter02;
using Shared.LinkedLists;
using Xunit;

namespace Chapters.Tests.Chapter02;

public class IntersectionTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { -1, -2, -3 }, new[] { 10, 20, 30 })]
    public void DetectsIntersections(int[] startA, int[] startB, int[] commonPart)
    {
        var headA = NodeHelper.FromEnumerable(startA);
        var headB = NodeHelper.FromEnumerable(startB);
        var headCommon = NodeHelper.FromEnumerable(commonPart);
        NodeHelper.AppendToTail(headA, headCommon);
        NodeHelper.AppendToTail(headB, headCommon);

        var actual = Solutions.GetIntersectionNode(headA, headB);
        Assert.Same(headCommon, actual);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    public void DetectsNoIntersections(int[] inputA, int[] inputB)
    {
        var headA = NodeHelper.FromEnumerable(inputA);
        var headB = NodeHelper.FromEnumerable(inputB);

        var actual = Solutions.GetIntersectionNode(headA, headB);
        Assert.Null(actual);
    }
}