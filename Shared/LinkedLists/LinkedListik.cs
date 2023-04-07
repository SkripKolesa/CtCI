using System.Text;

namespace Shared.LinkedLists;

public class LinkedListik
{
    public Node<int> Head { get; set; }

    public LinkedListik(Node<int> head)
    {
        Head = head;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var n = Head;
        sb.Append(n.Value);
        while (n.Next != null)
        {
            n = n.Next;
            sb.Append(n.Value);
        }

        return sb.ToString();
    }
}