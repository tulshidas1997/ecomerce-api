using Core.Models;

namespace Core.Interfaces;

public interface IBaseRepository<TEntity,TKey> where TEntity : BaseModel<TKey>
{
    IQueryable<TEntity> All();
    void AddToContext(TEntity entity);
    bool Add(TEntity entity);
    void AddListToContext(IEnumerable<TEntity> entities);
    bool AddList(IEnumerable<TEntity> entities);
    void DeleteFromContext(TEntity entity);
    void Delete(TEntity entity);
    void DeleteListFromContext(IEnumerable<TEntity> entities);
    void DeleteList(IEnumerable<TEntity> entities);
    Task DeleteListAsync(IEnumerable<TEntity> entities);
    bool SaveChanges();
    Task<bool> SaveChangesAsync();

    Task<bool> AddAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    Task ParmentDeleteAsync(TEntity entity);
    void ParmanentDeleteFromContext(TEntity entity);
    void ParmanentDeleteList(IEnumerable<TEntity> entities);
    Task ParmanentDeleteListAsync(IEnumerable<TEntity> entities);
}





//donot add properties/fields/methods to this class. Do that in the above class.
public interface IBaseRepository<TEntity>:IBaseRepository<TEntity, int> where TEntity : BaseModel { }