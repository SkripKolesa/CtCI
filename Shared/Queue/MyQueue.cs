using System;

namespace Shared.Queue;

public class MyQueue<T> : IMyQueue<T>
{
    private class QueueNode<T>
    {
        public T Data { get; set; }
        public QueueNode<T> Next { get; set; }
    }

    private QueueNode<T> _first;
    private QueueNode<T> _last;

    public void Add(T item)
    {
        var newNode = new QueueNode<T>(){Data = item};
        if (_last is not null)
        {
            _last.Next = newNode;
        }
        _last = newNode;
        _first ??= _last;
    }

    public T Remove()
    {
        if (IsEmpty()) throw new InvalidOperationException("queue is empty");
        var data = _first.Data;
        _first = _first.Next;
        if (_first is null)
        {
            _last = null;
        }

        return data;
    }

    public T Peek()
    {
        if (IsEmpty()) throw new InvalidOperationException("queue is empty");
        return _first.Data;
    }

    public bool IsEmpty()
    {
        return _first is null;
    }
}