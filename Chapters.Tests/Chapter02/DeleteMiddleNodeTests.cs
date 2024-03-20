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
        foreach (var v in input.Skip(1))
        {
            NodeHelper.AppendToTail(head, v);
        }
        var list = new MyLinkedList(head);
        
        Solutions.DeleteMiddleNode(list, valueToDelete);
        
        Assert.Equal(String.Join(',', expected), list.ToString());
    }
}