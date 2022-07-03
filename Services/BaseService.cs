using Core.Dtos;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models;

namespace Services;

public class BaseService<TDto, TKey> : IBaseService<TDto,TKey> where TDto : BaseDto<TKey>
{
    private readonly IBaseRepository<BaseModel<TKey>, TKey> _repo;

    public BaseService(IBaseRepository<BaseModel<TKey>, TKey> repo)
    {
        _repo = repo;
    }
    public async Task<List<TDto>> GetAll()
    {
        var list = await _repo.GetAll();

        throw new NotImplementedException();
    }

    public Task<TDto> GetById(TKey Id)
    {
        throw new NotImplementedException();
    }

    public Task Create(TDto dto)
    {
        throw new NotImplementedException();
    }

    public Task Update(TDto dto)
    {
        throw new NotImplementedException();
    }

    public Task Delete(TKey Id)
    {
        throw new NotImplementedException();
    }

    public Task ParmanentDelete(TKey Id)
    {
        throw new NotImplementedException();
    }
}