using Application.Contracts.Persistence;
using Application.Dtos;
using AutoMapper;
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
        private readonly IMapper _automapper; 
        public ProductBL(IProductRepository productRepository,IMapper automapper)
        {
            _productRepository = productRepository;
            _automapper = automapper;
        }

        public void AddProduct(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public ProductDto GetSingleProduct(int id)
        {
            // Recupère le produit dans la base de donnée 
            Product? currentProduct = _productRepository.GetById(id);

            if (currentProduct == null)
            {
                throw new Exception();
            }

            // Mapping data 
            ProductDto? productDto = _automapper.Map<ProductDto>(currentProduct);

            return productDto;
        }

        public void UpdateProduct(ProductDto product)
        {
            throw new NotImplementedException();
        }
    }
}
