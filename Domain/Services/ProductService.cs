using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        /// <summary>
        /// Methode permettant d'ajouter un produit 
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            _productRepository.Add(product);
        }
    }
}
