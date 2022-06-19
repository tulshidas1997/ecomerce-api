using Core.Models;

namespace Core.Interfaces;

public interface IBaseRepository<T,K> where T : BaseModel<K>
{
    IEnumerable<T> All();
    void AddToContext(T entry);
    Task Add(T entry);
    void AddListToContext(IEnumerable<T> entities);
    Task AddList(IEnumerable<T> entities);
    void DeleteFromContext(T entry);
    Task Delete(T entry);
    Task SaveChanges();



}





//donot add properties/fields/methods to this class. Do that in the above class.
public interface IBaseRepository<T>:IBaseRepository<T, int> where T : BaseModel { }