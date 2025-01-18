using CleanArchitecture.Core.Dtos;
using CleanArchitecture.Core.Interfaces.Services;
using CleanArchitecture.Core.Types;
using Core.Dtos;
using Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ApiController
    {

        private readonly IProductService _product;

        public ProductController(IProductService product)
        {
            _product = product;
        }
        
        [HttpGet("all")]
        public async Task<ActionResult<ApiResult<List<ProductDto>>>> GetAll()
        {
            var cows = await _product.GetAll();
            return OkResult(cows);
        }

        [HttpPost]
        public async Task<ActionResult<ApiResult<ProductDto>>> Create(ProductDto product)
        {
            var result = await _product.Create(product);
            return OkResult(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResult<ProductDto>>> Create(int id)
        {
            var result = await _product.GetById(id);
            return OkResult(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResult<bool>>> Remove(int id)
        {
            await _product.ParmanentDelete(id);
            return OkResult(true);
        }
    }
}
