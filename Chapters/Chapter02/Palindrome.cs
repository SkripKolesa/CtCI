using System;
using System.Collections.Generic;
using Shared.LinkedLists;

namespace Chapters.Chapter02;

/// <summary>
/// 2.6 Palindrome: Implement a function to check if a linked list is a palindrome.
/// </summary>
public static partial class Solutions
{
    public static bool IsPalindrome<T>(Node<T> head)
    {
        var current = head;
        var endSeeker = current;
        var compareBuffer = new Stack<T>();
        var isLengthOdd = false;
        while (endSeeker is not null)
        {
            compareBuffer.Push(current.Value);
            current = current.Next;
            if (endSeeker.Next is null)
            {
                isLengthOdd = true;
            }
            endSeeker = endSeeker.Next?.Next;
        }

        if (isLengthOdd)
        {
            compareBuffer.Pop();
        }

        while (current is not null)
        {
            if (!current.Value.Equals(compareBuffer.Pop()))
            {
                return false;
            }
            current = current.Next;
        }

        return true;
    }
}