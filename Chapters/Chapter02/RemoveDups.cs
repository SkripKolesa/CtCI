using System;
using System.Collections.Generic;
using Shared.LinkedLists;

namespace Chapters.Chapter02;

/// <summary>
/// 2.1 Remove Dups: Write code to remove duplicates from an unsorted linked list.
/// FOLLOW UP: How would you solve this problem if a temporary buffer is not allowed?
/// </summary>
public static partial class Solutions
{
    public static Node<T> RemoveDuplicates<T>(Node<T> head)
    {
        var current = head;
        var metItems = new HashSet<T> { head.Value };
        var newHead = new Node<T>(head.Value);
        while (current.Next is not null)
        {
            current = current.Next;
            if (metItems.Add(current.Value))
            {
                NodeHelper.AppendToTail(newHead, current.Value);
            }
        }

        return newHead;
    }

    public static Node<T> RemoveDuplicatesNoBuffer<T>(Node<T> head)
    {
        var current = head;
        var newHead = new Node<T>(head.Value);
        while (current is not null)
        {
            var hasDuplicate = false;
            var runner = newHead;
            while (runner != null && !hasDuplicate)
            {
                if (runner.Value.Equals(current.Value))
                {
                    hasDuplicate = true;
                }

                runner = runner.Next;
            }

            if (!hasDuplicate)
            {
                NodeHelper.AppendToTail(newHead, current.Value);
            }

            current = current.Next;
        }

        return newHead;
    }
}