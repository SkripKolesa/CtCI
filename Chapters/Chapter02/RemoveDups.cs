using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Shared.LinkedLists;

namespace Chapters.Chapter02;

/// <summary>
/// 2.1 Remove Dups: Write code to remove duplicates from an unsorted linked list.
/// FOLLOW UP: How would you solve this problem if a temporary buffer is not allowed?
/// </summary>
public static partial class Solutions
{
    public static void RemoveDuplicates<T>(Node<T> head)
    {
        var current = head;
        var prev = current;
        var metItems = new HashSet<T> { head.Value };
        while (current.Next is not null)
        {
            current = current.Next;
            if (!metItems.Add(current.Value))
            {
                prev.Next = current.Next;
            }
            else
            {
                prev = prev.Next;
            }
        }
    }

    public static void RemoveDuplicatesNoBuffer<T>(Node<T> head)
    {
        var current = head;
        while (current != null)
        {
            var runner = current;
            while (runner.Next != null)
            {
                if (runner.Next.Value.Equals(current.Value))
                {
                    runner.Next = runner.Next.Next;
                }
                else
                {
                    runner = runner.Next;
                }
            }
            current = current.Next;
        }
    }
}