// See https://aka.ms/new-console-template for more information

using Ds04.StacksQueues.Exercises;

var queue = new StackAsQueue<int>();

Console.WriteLine("Stack as queue");
Console.WriteLine("------------------------------------------");
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);


while (queue.Count > 0)
{
    var popped =  queue.Dequeue();
    Console.Write($"{popped},");
}