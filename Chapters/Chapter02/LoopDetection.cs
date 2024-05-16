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
        var fastRunner = head.Next;
        var isLoop = false;
        int counter = 0;
        while (runner is not null && fastRunner is not null)
        {
            counter++;
            runner = runner.Next;
            fastRunner = fastRunner?.Next?.Next;
            if (fastRunner is null)
            {
                isLoop = false;
                break;
            }

            if (fastRunner.Next == runner || fastRunner == runner || runner.Next == fastRunner)
            {
                isLoop = true;
                break;
            }
        }

        if (isLoop)
        {
            var stepsToTail = (counter + 1) / 2;
            while (stepsToTail > 0)
            {
                runner = runner.Next;
                stepsToTail--;
            }

            loopNode = runner.Next;
        }

        return isLoop;
    }
}