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
        while (n.Next != null)
        {
            sb.Append(n.Value);
            n = n.Next;
        }

        sb.Append(n.Value);

        return sb.ToString();
    }
}