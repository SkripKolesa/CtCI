using System;
using System.Collections.Generic;
using Shared.LinkedLists;

namespace Chapters.Tests.Common.LinkedListTools;

public class ListTester<T>
{
    public class Options
    {
        public int? Pebble { get; set; }
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
        throw new NotImplementedException();
    }

    public string UserMessage => String.Join(Environment.NewLine, _userMessages);
}