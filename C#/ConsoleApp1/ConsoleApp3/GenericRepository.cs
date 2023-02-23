namespace ConsoleApp3;


file class GenericRepository<T> : IRepository<T> where T: class, IEntity
{
    private List<T> list = new List<T>();
    public void Add(T item)
    {
        list.Add(item);
    }

    public void Remove(T item)
    {
        if (list.Contains(item))
        {
            list.Remove(item);
        }
    }

    public Void Save()
    {
        
    }

    public IEnumerable<T> GetAll()
    {
        return list.AsEnumerable() ;
    }

    public T GetById(int id)
    {
        return list.FirstOrDefault(item => item.Id == id);
    }
}

