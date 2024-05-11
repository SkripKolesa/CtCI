using System;
using Shared.LinkedLists;

namespace Chapters.Chapter02;

/// <summary>
/// 2.4 Write code to partition a linked list around a value x, such that all nodes less than x come
/// before all nodes greater than or equal to x. If x is contained within the list, the values of x only need to be after
/// the elements less than x (see below). The partition element x can appear anywhere in the "right partition"; it does
/// not need to appear between the left and right partitions.
/// EXAMPLE
/// Input: 3->5->8->5->10->2->1 [partition = 5]
/// Output: 3->1->2->10->5->5->8
/// </summary>
public static partial class Solutions
{
    public static Node<T> Partition<T>(Node<T> head, int pebble) where T:IComparable
    {
        var leftHead = new Node<T>();
        var rightHead = new Node<T>();
        var current = head;
        while (current != null)
        {
            NodeHelper.AppendToTail(current.Value.CompareTo(pebble) < 0 ? leftHead : rightHead, current.Value);
            current = current.Next;
        }

        current = leftHead;
        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = rightHead.Next;
        return leftHead.Next;
    }
}