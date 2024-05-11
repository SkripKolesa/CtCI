using System;
using Shared.LinkedLists;

namespace Chapters.Chapter02;

/// <summary>
/// 2.2 Implement an algorithm to find the kth to last element of a singly linked list
/// </summary>
public static partial class Solutions
{
    public static T KthToLast<T>(Node<T> head, int k)
    {
        var current = head;
        var distanceRunner = current;
        var distance = 0;
        while (current.Next is not null)
        {
            current = current.Next;
            if (distance < k)
            {
                distance++;
            }
            else
            {
                distanceRunner = distanceRunner.Next;
            }
        }

        return distanceRunner.Value;
    }
}