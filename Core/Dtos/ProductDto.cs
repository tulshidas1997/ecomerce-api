using CleanArchitecture.Core.Interfaces.Common;
using CleanArchitecture.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Dtos
{
    public class ProductDto:BaseDto,IMapFrom<Product>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
