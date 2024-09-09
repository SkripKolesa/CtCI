namespace Shared.Stack;

public interface IMyStack<T>
{
    T Pop();
    void Push(T item);
    T Peek();
    bool IsEmpty();
}