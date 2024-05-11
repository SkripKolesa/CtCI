using System;
using System.Collections.Generic;
using Shared.LinkedLists;

namespace Chapters.Tests.Common.LinkedListTools;

public class ListTester<T>
{
    public class Options
    {
        public IComparable? Pebble { get; set; }
    }

    private readonly Node<T> _head;
    private readonly Options _options;
    private List<string> _userMessages = new();

    public ListTester(Node<T> head, Options options)
    {
        _head = head;
        _options = options;
    }

    public bool IsPartitioned()
    {
        if (_options.Pebble is null) throw new ArgumentNullException(nameof(_options.Pebble));
        var current = _head;
        var isCheckingRight = false;
        while (current != null)
        {
            var v = current.Value as IComparable;
            if (v is null)
                throw new ArgumentException($"was not able to use {current.Value} as IComparable",
                                            nameof(current.Value));

            if (v.CompareTo(_options.Pebble) < 0)
            {
                if (isCheckingRight) return false;
            }
            else
            {
                isCheckingRight = true;
            }

            current = current.Next;
        }

        return true;
    }

    public string UserMessage => String.Join(Environment.NewLine, _userMessages);
}