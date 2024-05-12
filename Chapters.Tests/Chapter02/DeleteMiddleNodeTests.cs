using System;
using System.Linq;
using Chapters.Chapter02;
using Shared.LinkedLists;
using Xunit;

namespace Chapters.Tests.Chapter02;

public class DeleteMiddleNodeTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, 3, new[] { 1, 2, 4 })]
    [InlineData(new[] { 1, 2, 3, 4 }, 2, new[] { 1, 3, 4 })]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 4, new[] { 1, 2, 3, 5 })]
    public void DeletesMiddleNode(int[] input, int valueToDelete, int[] expected)
    {
        var head = new Node<int>(input.First());
        Node<int> nodeToDelete = null;
        foreach (var v in input.Skip(1))
        {
            var n = new Node<int>(v);
            if (v == valueToDelete)
            {
                nodeToDelete = n;
            }

            NodeHelper.AppendToTail(head, n);
        }

        var expectedHead = NodeHelper.FromEnumerable(expected);

        if (nodeToDelete is null) throw new InvalidOperationException("test didn't acquired data");
        Solutions.DeleteMiddleNode(nodeToDelete);

        Assert.Equal(NodeHelper.DebugString(expectedHead), NodeHelper.DebugString(head));
    }
}