using Domain.Contracts;
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
