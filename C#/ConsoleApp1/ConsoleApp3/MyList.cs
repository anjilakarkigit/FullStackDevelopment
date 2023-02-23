namespace ConsoleApp3;

public class MyList<T>
{
    private List<T> list = new List<T>(); 
    
    public void Add(T element)
    {
        list.Add(element);
    }

    public T Remove(int index)
    {
        T temp = list[index];
        list.RemoveAt(index);
        return temp;
    }

    public bool Contains(T element)
    {
        if (list.Contains(element))
        {
            return true;
        }

        return false;
    }

    public void Clear()
    {
        list.Clear();
    }

    public void InsertAt(T element, int index)
    {
        list.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        list.RemoveAt(index);
    }

    public T Find(int index)
    {
        return list[index];
    }
}