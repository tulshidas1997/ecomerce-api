using Core.Interfaces;
using Core.Models;

namespace Repositories;

public class BaseRepository<T, K> : IBaseRepository<T, K> where T:BaseModel<K>
{
    //public  Type { get; set; }
    public Task Add(T entry)
    {
        throw new NotImplementedException();
    }

    public Task AddList(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public void AddListToContext(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public void AddToContext(T entry)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> All()
    {
        throw new NotImplementedException();
    }

    public Task Delete(T entry)
    {
        throw new NotImplementedException();
    }

    public void DeleteFromContext(T entry)
    {
        throw new NotImplementedException();
    }

    public Task SaveChanges()
    {
        throw new NotImplementedException();
    }
}

public class BaseRepository<T>:BaseRepository<T,int> where T:BaseModel{};