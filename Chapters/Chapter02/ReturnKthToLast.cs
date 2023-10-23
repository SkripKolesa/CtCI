using System;
using Shared.LinkedLists;

namespace Chapters.Chapter02;

/// <summary>
/// 2.2 Implement an algorithm to find the kth to last element of a singly linked list
/// </summary>
public static class ReturnKthToLast
{
    public static int KthToLast(this MyLinkedList list, int k)
    {
        var current = list.Head;
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