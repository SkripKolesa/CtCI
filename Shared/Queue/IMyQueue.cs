namespace Shared.Queue;

public interface IMyQueue<T>
{
    void Add(T item);
    T Remove();
    T Peek();
    bool IsEmpty();
}