using Application.Contracts.Persistence;
using Application.Dtos;
using Domain.Entities;
using Domain.InterfacesRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BusinessLogic
{
    public class ProductBL : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductBL(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(ProductDto product)
        {
            throw new NotImplementedException();
        }
    }
}
