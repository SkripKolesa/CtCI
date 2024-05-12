using System;
using Shared.LinkedLists;

namespace Chapters.Chapter02;
/// <summary>
/// 2.5 Sum Lists: You have two numbers represented by a linked list, where each node contains a single digit. The digits
/// are stored in reversed order, such as the 1's digit is at the head of the list.
/// Write a function that adds the two numbers and returns the sum as linked list.
/// EXAMPLE
/// Input: (7->1->6) + (5->9->2). That is, 617+295
/// Output: 2->1->9. That is, 912
/// FOLLOW UP
/// Suppose the digits are stored in forward order. Repeat the above problem.
/// EXAMPLE
/// Input: (6->1->7) + (2->9->5). That is, 617+295
/// Output: 9->1->2. That is, 912
/// </summary>
public partial class Solutions
{
    public static Node<byte> Sum(Node<byte> a, Node<byte> b)
    {
        var currentA = a;
        var currentB = b;
        var isAnyLeft = true;
        Node<byte> resultHead = null;
        byte overflowDigit = 0;
        while (isAnyLeft)
        {
            var intermittentResult = (currentA?.Value ?? 0) + (currentB?.Value ?? 0);
            intermittentResult+=overflowDigit;
            overflowDigit = (byte)(intermittentResult / 10);
            
            var resultDigitNode = new Node<byte>((byte)(intermittentResult % 10));
            if (resultHead is not null)
            {
                NodeHelper.AppendToTail(resultHead, resultDigitNode);
            }
            else
            {
                resultHead = resultDigitNode;
            }
            
            currentA = currentA?.Next;
            currentB = currentB?.Next;
            isAnyLeft = currentA is not null || currentB is not null;
        }

        return resultHead;
    }
}