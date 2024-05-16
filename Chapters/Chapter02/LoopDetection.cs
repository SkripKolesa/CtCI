using System;
using Shared.LinkedLists;

namespace Chapters.Chapter02;

/// <summary>
/// Loop Detection: Given a circular linked list, implement an algorithm that returns the node at the beginning
/// of the loop.
/// DEFINITION
/// Circular linked list: A (corrupt) linked list in which a node's next pointer points to an earlier node, so as to
/// make a loop in the linked list.
/// EXAMPLE
/// Input: A -> B -> C -> D -> E -> C (the same C as earlier)
/// Output: C
/// </summary>
public static partial class Solutions
{
    public static bool TryGetLoopNode<T>(Node<T> head, out Node<T> loopNode)
    {
        loopNode = null;

        var runner = head;
        var fastRunner = head;
        var isLoop = false;
        while (runner is not null && fastRunner is not null)
        {
            runner = runner.Next;
            fastRunner = fastRunner?.Next?.Next;
            if (fastRunner == runner && runner != null)
            {
                isLoop = true;
                break;
            }
        }

        //h = head size, l = loop size, x = position in the loop, k = position in the list
        // h + x = k; h + l + x = 2k => l = k => l-x = h. So the distance to he beginning of the loop is same from
        //the beginning and from the collision point => we can run again from head and collision point and meet at it
        if (isLoop)
        {
            var collisionPoint = runner;
            runner = head;
            while (runner != collisionPoint)
            {
                runner = runner.Next;
                collisionPoint = collisionPoint.Next;
            }

            loopNode = runner;
        }

        return isLoop;
    }
}