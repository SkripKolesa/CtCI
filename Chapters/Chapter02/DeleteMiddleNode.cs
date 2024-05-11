using Shared.LinkedLists;

namespace Chapters.Chapter02;

/// <summary>
/// 2.3 Implement an algorithm to delete a node in the middle (i.e., any node but the first and last node,
/// note necessarily the exact middle) of a singly linked list, given only access to that node.
/// EXAMPLE
/// Input: the node c from the linked list a->b->c->d->e->f
/// Result: nothing is returned but the new linked list looks like a->b->d->e->f
/// </summary>
public static partial class Solutions
{
    public static void DeleteMiddleNode<T>(Node<T> head, T value)
    {
        var node = GetFirstNodeByValue(head, value);
        DeleteMiddleNode(head, node);
    }

    private static Node<T> GetFirstNodeByValue<T>(Node<T> head, T value)
    {
        var current = head;
        while (current != null)
        {
            if (current.Value.Equals(value)) return current;
            current = current.Next;
        }

        return null;
    }

    private static void DeleteMiddleNode<T>(Node<T> head, Node<T> node)
    {
        var preNode = FindPreviousToNode(head, node);
        preNode.Next = node.Next;
    }

    private static Node<T> FindPreviousToNode<T>(Node<T> head, Node<T> node)
    {
        var current = head;
        Node<T> preNode = null;
        while (current.Next != null)
        {
            if (current.Next == node)
            {
                preNode = current;
                break;
            }

            current = current.Next;
        }

        return preNode;
    }
}