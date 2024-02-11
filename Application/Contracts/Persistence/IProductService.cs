using Application.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Persistence
{
    public  interface IProductService
    {
        void AddProduct(ProductDto product);
        void UpdateProduct(ProductDto product);
        
    }
}
