namespace ConsoleAppHT3_1;


using System.Collections.Generic;


public class Queue<T> : IQueue<T> where T : struct
{
    private readonly LinkedList<T> _queue = new();
    
    public void Enqueue(T value)
    {
        _queue.AddLast(value);    
    }

    public T Dequeue()
    {
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        T value = _queue.First();
        _queue.RemoveFirst();
        return value;
    }

    public bool IsEmpty() => _queue.Count == 0;
}

public static class QueueExtension
{
    public static IQueue<T> Tail<T>(this IQueue<T> queue) where T : struct
    {
        if (queue.IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }
        queue.Dequeue();
        return queue;
    }
}