using Domain.Entities;
using Domain.InterfacesRepository;
using Emp.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public readonly EcommerceContext _context; 

        public ProductRepository(EcommerceContext context)
        {
            _context = context;
        }


        public void Add(Product product)
        {
           _context.Add(product);

          _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Product? currentProduct = this.GetById(id);

            currentProduct.IsActive = false;
            _context.Update(currentProduct);

            _context.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
           return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
           return _context.Products.First(p => p.Id == id);
        }

        public void Update(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
        }
    }
}
