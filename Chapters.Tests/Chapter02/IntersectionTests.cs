using Chapters.Chapter02;
using Shared.LinkedLists;
using Xunit;

namespace Chapters.Tests.Chapter02;

public class IntersectionTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 10, 20, 30 }, new[] { 100, 200, 300 })]
    [InlineData(new[] { 1, 2, 3 }, new[] { 10, 20, 30 }, new[] { 100, 200, 300 })]
    [InlineData(new[] { 1 }, new[] { 10, 20, 30 }, new[] { 100, 200, 300 })]
    [InlineData(new[] { 1, 2 }, new[] { 10 }, new[] { 100, 200, 300 })]
    [InlineData(new[] { 1, 2 }, new[] { 10, 20, 30 }, new[] { 100 })]
    [InlineData(new[] { 1 }, new[] { 10 }, new[] { 100 })]
    public void DetectsIntersections(int[] startA, int[] startB, int[] commonPart)
    {
        var headA = NodeHelper.FromEnumerable(startA);
        var headB = NodeHelper.FromEnumerable(startB);
        var headCommon = NodeHelper.FromEnumerable(commonPart);
        NodeHelper.AppendToTail(headA, headCommon);
        NodeHelper.AppendToTail(headB, headCommon);

        var isIntersection = Solutions.TryGetIntersectionNode(headA, headB, out var intersectionNode);
        
        Assert.True(isIntersection);
        Assert.Same(headCommon, intersectionNode);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 10, 20, 30 })]
    [InlineData(new[] { 1, 2, 3 }, new[] { 10 })]
    [InlineData(new[] { 1 }, new[] { 10, 20 })]
    [InlineData(new[] { 1 }, new[] { 10 })]
    public void DetectsNoIntersections(int[] inputA, int[] inputB)
    {
        var headA = NodeHelper.FromEnumerable(inputA);
        var headB = NodeHelper.FromEnumerable(inputB);

        var isIntersection = Solutions.TryGetIntersectionNode(headA, headB, out var intersectionNode);
        
        Assert.False(isIntersection);
        Assert.Null(intersectionNode);
    }
}