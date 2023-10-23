using System;
using System.Collections.Generic;
using Shared.LinkedLists;

namespace Chapters.Chapter02;

/// <summary>
/// 2.1 Remove Dups: Write code to remove duplicates from an unsorted linked list.
/// FOLLOW UP: How would you solve this problem if a temporary buffer is not allowed?
/// </summary>
public static class RemoveDups
{
    public static MyLinkedList RemoveDuplicates(this MyLinkedList myLinkedList)
    {
        var n = myLinkedList.Head;
        var metItems = new HashSet<int>();
        metItems.Add(n.Value);
        var newHead = new Node<int>(n.Value);
        var newList = new MyLinkedList(newHead);
        while (n.Next != null)
        {
            n = n.Next;
            if (metItems.Add(n.Value))
            {
                NodeHelper.AppendToTail(newHead, n.Value);
            }
        }

        return newList;
    }

    public static MyLinkedList RemoveDuplicatesNoBuffer(this MyLinkedList myLinkedList)
    {
        var n = myLinkedList.Head;
        var newHead = new Node<int>(n.Value);
        while (n != null)
        {
            var hasDuplicate = false;
            var runner = newHead;
            while (runner != null && !hasDuplicate)
            {
                if (runner != n && runner.Value == n.Value)
                {
                    hasDuplicate = true;
                }

                runner = runner.Next;
            }

            if (!hasDuplicate)
            {
                NodeHelper.AppendToTail(newHead, n.Value);
            }

            n = n.Next;
        }

        return new MyLinkedList(newHead);
    }
}