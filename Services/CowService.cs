using AutoMapper;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Core.Interfaces.Services;
using Core.Dtos;
using Core.Models;

namespace CleanArchitecture.Services;

public class CowService:BaseService<Cow,CowDto>,ICowService
{
    public readonly ICowRepository _repo;
    public readonly IMapper _mapper;
    public CowService(ICowRepository repo, IMapper mapper) : base(repo, mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }
    
}