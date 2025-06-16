namespace Ds04.StacksQueues.Exercises;

public class StackAsQueue<T>
{
    private readonly Stack<T> _queue = new Stack<T>();
    private readonly Stack<T> _stack = new Stack<T>();
    
    public int Count => _queue.Count;
    
    public void Enqueue(T item)
    {
        while (_queue.Count != 0)
        {
            _stack.Push(_queue.Pop());
        }
        
        _queue.Push(item);

        while (_stack.Count != 0)
        {
            _queue.Push(_stack.Pop());
        }
    }

    public T? Dequeue()
    {
        return _queue.Count == 0 ? default : _queue.Pop();
    }
}