using AutoMapper;
using CleanArchitecture.Core.Dtos;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Core.Interfaces.Services;
using Core.Models;

namespace CleanArchitecture.Services;

public class BaseService<TEntity, TDto, TKey> : IBaseService<TDto,TKey> where TEntity : BaseModel<TKey> where TDto : BaseDto<TKey> 
{
    private readonly IBaseRepository<TEntity, TKey> _repo;
    protected readonly IMapper _mapper;

    public BaseService(IBaseRepository<TEntity, TKey> repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }
    public async Task<List<TDto>> GetAll()
    {
        var list = await _repo.GetAll();
        return _mapper.Map<List<TDto>>(list);
    }

    public async Task<TDto> GetById(TKey Id)
    {
        var item = await _repo.GetById(Id);

        return _mapper.Map<TDto>(item);
    }

    public async Task<TDto> Create(TDto dto)
    {
        var entity = _mapper.Map<TEntity>(dto);
        await _repo.AddAsync(entity);
        return _mapper.Map<TDto>(entity);
    }

    public Task Update(TDto dto)
    {
        throw new NotImplementedException();
    }

    public Task Delete(TKey Id)
    {
        throw new NotImplementedException();
    }

    public async Task ParmanentDelete(TKey Id)
    {
        var entity = await _repo.GetById(Id);
        await _repo.ParmentDeleteAsync(entity);
    }
}


//do not add properties/fields/methods to this class. Do that in the above class.

public class BaseService<TEntity,TDto> :BaseService<TEntity,TDto, int> , IBaseService<TDto> where TEntity : BaseModel where TDto:BaseDto
{
    public BaseService(IBaseRepository<TEntity> repo, IMapper mapper) : base(repo,mapper)
    {
    }
}