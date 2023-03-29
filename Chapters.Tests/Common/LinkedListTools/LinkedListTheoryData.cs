using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Shared.LinkedLists;
using Xunit;

namespace Chapters.Tests.Common.LinkedListTools;

public class LinkedListTheoryData: TheoryData<LinkedListik,string>
{
    public LinkedListTheoryData(IEnumerable<int[]> inputInts, IEnumerable<int[]> outputInts)
    {
        var inputs = inputInts.ToArray();
        var outputs = outputInts.ToArray();
        for (int i = 0; i < inputs.Length; i++)
        {
            var input = inputs[i];
            var head = new Node<int>(input[0]);
            foreach (var v in input.Skip(1))
            {
                NodeHelper.AppendToTail(head, v);
            }
            var list = new LinkedListik(head);
            var output = String.Join(String.Empty, outputs[i]);
            Add(list, output);
        }
    }
}