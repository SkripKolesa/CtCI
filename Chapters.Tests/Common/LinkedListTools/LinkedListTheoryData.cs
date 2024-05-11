using System.Collections.Generic;
using System.Linq;
using Shared.LinkedLists;
using Xunit;

namespace Chapters.Tests.Common.LinkedListTools;

public class LinkedListTheoryData<T> : TheoryData<Node<T>, Node<T>>
{
    public LinkedListTheoryData(IEnumerable<T[]> inputInts, IEnumerable<T[]> outputInts)
    {
        var inputs = inputInts.ToArray();
        var outputs = outputInts.ToArray();
        for (int i = 0; i < inputs.Length; i++)
        {
            var input = inputs[i];
            var output = outputs[i];
            var inputHead = NodeHelper.FromEnumerable(input);
            var outputHead = NodeHelper.FromEnumerable(output);
            Add(inputHead, outputHead);
        }
    }
}