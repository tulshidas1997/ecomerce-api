using AutoMapper;
using CleanArchitecture.Core.Dtos;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Core.Interfaces.Services;
using CleanArchitecture.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Services
{
    public class ProductService:BaseService<Product,ProductDto>,IProductService
    {
        public readonly IProductRepository _repository;
        public ProductService(IProductRepository repo, IMapper mapper) :base(repo,mapper)
        {
            _repository = repo;
        }

        public async Task UpdateProduct(ProductDto productDto)
        {
            var entity = await _repository.GetById(productDto.Id);
            entity.Quantity = productDto.Quantity;
            await _repository.SaveChangesAsync();            
        }
    }
}
