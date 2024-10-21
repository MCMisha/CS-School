namespace ConsoleAppHT3_1;

public interface IQueue<T> where T : struct
{
    void Enqueue(T value);
    T Dequeue();
    bool IsEmpty();
}