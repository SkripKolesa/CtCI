using System;

namespace Shared.Stack;

public class MyStack<T> : IMyStack<T>
{
    private class StackNode<T>
    {
        public T Data { get; set; }
        public StackNode<T> Next { get; set; }
    }

    private StackNode<T> _top;

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty");
        }

        var t = _top.Data;
        _top = _top.Next;
        return t;
    }

    public void Push(T item)
    {
        var newNode = new StackNode<T>() { Data = item };
        newNode.Next = _top;
        _top = newNode;
    }

    public T Peek()
    {
        if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
        return _top.Data;
    }

    public bool IsEmpty()
    {
        return _top is null;
    }
}