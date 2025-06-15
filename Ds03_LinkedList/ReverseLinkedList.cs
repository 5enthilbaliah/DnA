namespace Ds03_LinkedList;

public class ReverseLinkedList(LinkedListNode<int> head)
{
    private LinkedListNode<int> _head = head;

    public void Execute()
    {
        var linkedList = new LinkedList<int>();
        linkedList.AddFirst(new  LinkedListNode<int>(_head.Value));

        while (_head.Next != null)
        {
            var next = _head.Next;
            linkedList.AddFirst(new LinkedListNode<int>(next.Value));
            _head = _head.Next;
        }

        var current = linkedList.First;
        while (current != null)
        {
            Console.Write(current.Next != null ? $"{current.Value} -> " : $"{current.Value}");
            current = current.Next;
        }
        
    }
}