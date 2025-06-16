// See https://aka.ms/new-console-template for more information

using Ds03_LinkedList.Exercises;

var linkedList = new LinkedList<int>();
linkedList.AddFirst(1);
linkedList.AddLast(10);
linkedList.AddLast(16);
linkedList.AddLast(88);

var reverseLinkedList = new ReverseLinkedList(linkedList.First!);
reverseLinkedList.Execute();

