using System.Collections;

namespace ConsoleApp3;

public class MyStack<T>
{
    private Stack<T> stack = new Stack<T>(); 
    
    public int Count()
    {
        return stack.Count;
    }

    public T Pop()
    {
        return stack.Pop();
    }

    public Void Push(T item)
    {
        stack.Push(item);
    }
}