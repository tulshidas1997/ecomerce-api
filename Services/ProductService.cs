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
        public ProductService(IProductRepository repo, IMapper mapper) :base(repo,mapper)
        {
        }
    }
}
