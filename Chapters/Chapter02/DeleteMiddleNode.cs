using Shared.LinkedLists;

namespace Chapters.Chapter02;

/// <summary>
/// Implement an algorithm to delete a node in the middle (i.e., any node but the first and last node,
/// note necessarily the exact middle) of a singly linked list, given only access to that node.
/// EXAMPLE
/// Input: the node c from the linked list a->b->c->d->e->f
/// Result: nothing is returned but the new linked list looks like a->b->d->e->f
/// </summary>
public static partial class Solutions
{
    public static void DeleteMiddleNode(MyLinkedList list, int value)
    {
        var node = GetFirstNodeByValue(list, value);
        DeleteMiddleNode(list, node);
    }

    private static Node<int> GetFirstNodeByValue(MyLinkedList list, int value)
    {
        var current = list.Head;
        while (current != null)
        {
            if (current.Value == value) return current;
            current = current.Next;
        }

        return null;
    }

    private static void DeleteMiddleNode(MyLinkedList list, Node<int> node)
    {
        var preNode = FindPreviousToNode(list, node);
        preNode.Next = node.Next;
    }

    private static Node<int> FindPreviousToNode(MyLinkedList list, Node<int> node)
    {
        var current = list.Head;
        Node<int> preNode = null;
        while (current.Next != null)
        {
            if (current.Next == node)
            {
                preNode = current.Next;
                break;
            }

            current = current.Next;
        }

        return preNode;
    }
}