using Chapters.Chapter02;
using Shared.LinkedLists;
using Xunit;

namespace Chapters.Tests.Chapter02;

public class LoopDetectionTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 10, 20, 30 })]
    [InlineData(new[] { 0, 1 }, new[] { 2, 3, 4, 5, 6, 7, 8, 9 })]
    [InlineData(new[] { 1, 2, 3 }, new[] { 10 })]
    [InlineData(new[] { 1 }, new[] { 10 })]
    [InlineData(new[] { 1 }, new[] { 10, 20 })]
    [InlineData(new[] { 1, 2 }, new[] { 10, 20 })]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 10, 20, 30 })]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 10, 20, 30, 40 })]
    public void DetectsLoop(int[] beginning, int[] loop)
    {
        var head = NodeHelper.FromEnumerable(beginning);
        var loopStart = NodeHelper.FromEnumerable(loop);
        var begTail = head;
        while (begTail.Next != null)
        {
            begTail = begTail.Next;
        }

        begTail.Next = loopStart;
        var loopTail = loopStart;
        while (loopTail.Next != null)
        {
            loopTail = loopTail.Next;
        }

        loopTail.Next = loopStart;

        var hasLoop = Solutions.TryGetLoopNode(head, out var actualNode);

        Assert.True(hasLoop);
        Assert.Same(loopStart, actualNode);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3 })]
    [InlineData(new[] { 1, 2 })]
    [InlineData(new[] { 1 })]
    public void NotDetectsLoop(int[] input)
    {
        var head = NodeHelper.FromEnumerable(input);

        var isLoop = Solutions.TryGetLoopNode(head, out var loopNode);

        Assert.False(isLoop);
        Assert.Null(loopNode);
    }
}
