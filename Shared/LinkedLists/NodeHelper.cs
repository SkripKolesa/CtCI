using System.Collections.Generic;

namespace Shared.LinkedLists;

public static class NodeHelper
{
    /// <summary>
    /// adds value to the end of the list
    /// </summary>
    /// <param name="head"></param>
    /// <param name="value"></param>
    /// <typeparam name="T"></typeparam>
    public static Node<T> AppendToTail<T>(Node<T> head, T value)
    {
        var node = new Node<T>(value);
        return AppendToTail(head, node);
    }

    private static Node<T> AppendToTail<T>(Node<T> head, Node<T> node)
    {
        while (head.Next != null) head = head.Next;
        head.Next = node;
        return head;
    }

    /// <summary>
    /// removes node with value and returns head
    /// </summary>
    /// <param name="head"></param>
    /// <param name="value"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static Node<T>? DeleteNode<T>(Node<T> head, T value)
    {
        var n = head;
        if (EqualityComparer<T>.Default.Equals(n.Value, value)) return n.Next; //TODO: check EqualityComparer usage in generics in 2023
        while (n.Next != null)
        {
            if (EqualityComparer<T>.Default.Equals(n.Next.Value, value))
            {
                n.Next = n.Next.Next;
                return head;
            }

            n = n.Next;
        }

        return head;
    }
}