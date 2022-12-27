using AutoMapper;
using CleanArchitecture.Core.Dtos;
using CleanArchitecture.Core.Interfaces.Repositories;
using Core.Models;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace CleanArchitecture.Test;

public class BaseTest<TEntity,TDto,TRepository> where TEntity:BaseModel where TDto:BaseDto where TRepository: class, IBaseRepository<TEntity>
{
    protected readonly TEntity _demoEntity;
    protected readonly TDto _demoDto;

    protected readonly Mock<TRepository> _repository;
    protected IMapper _mapper;

    public BaseTest(TEntity demoEntity,TDto demoDto, Mock<TRepository> repository)
    {
        _demoEntity = demoEntity;
        _demoDto = demoDto;
        _repository = repository;
    }

    [SetUp]
    public void SetUpBase()
    {
        _mapper = TestInitiator._serviceProvider.GetRequiredService<IMapper>();
        _repository.Setup(x => x.AddAsync(It.IsAny<TEntity>())).
            Returns(Task.FromResult(true));

        _repository.Setup(x => x.GetAll()).
            Returns(Task.FromResult(new List<TEntity>(){_demoEntity}));
    }
}