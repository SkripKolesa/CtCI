using System;
using Shared.LinkedLists;

namespace Chapters.Chapter02;

/// <summary>
/// Intersection: Given two (singly) linked lists, determine if the two lists intersect. Return the intersecting node.
/// Note that the intersection is defined based on reference, not value. That is, if the kth node of the first linked
/// list is the exact same node (by reference) as the jth node of the second linked list, then they are intersecting.
/// </summary>
public static partial class Solutions
{
    public static bool TryGetIntersectionNode<T>(Node<T> headA, Node<T> headB, out Node<T>? intersectionNode)
    {
        intersectionNode = null;
        var (lengthA, tailA) = GetListParams(headA);
        var (lengthB, tailB) = GetListParams(headB);
        if (!ReferenceEquals(tailA, tailB))
        {
            return false;
        }

        var first = lengthA >= lengthB ? headA : headB;
        var second = lengthA >= lengthB ? headB : headA;
        var diff = Math.Abs(lengthA - lengthB);
        while (diff > 0)
        {
            diff--;
            first = first.Next;
        }

        while (first != null)
        {
            if (ReferenceEquals(first, second))
            {
                intersectionNode = first;
                return true;
            }

            first = first.Next;
            second = second.Next;
        }

        return false;
    }

    private static Tuple<int, Node<T>> GetListParams<T>(Node<T> head)
    {
        var current = head;
        var tail = head;
        var length = 0;
        while (current != null)
        {
            length++;
            if (current.Next is null)
            {
                tail = current;
            }

            current = current.Next;
        }

        return new(length, tail);
    }
}