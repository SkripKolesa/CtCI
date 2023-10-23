using System.Collections.Generic;
using System.Linq;
using Chapters.Chapter02;
using Chapters.Tests.Common.LinkedListTools;
using Shared.LinkedLists;
using Xunit;

namespace Chapters.Tests.Chapter02;

public class ReturnKthToLastTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, 4)]
    public void ReturnsKthToLast(int[] input, int k, int expected)
    {
        var head = new Node<int>(input[0]);
        foreach (var v in input.Skip(1))
        {
            NodeHelper.AppendToTail(head, v);
        }

        var list = new MyLinkedList(head);
        var actual = list.KthToLast(k);
        Assert.Equal(expected, actual);
    }
    
}