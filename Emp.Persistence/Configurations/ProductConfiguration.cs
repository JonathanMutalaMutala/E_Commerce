using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                Description = "An apple mobile which is nothing like apple",
                IsActive = true,
                ProductName = "Apple", 
                Price = 1200,
                Rating = 4.6m,
            },
            new Product
            {
                Id = 2, 
                Description = "Samsung S10",
                ProductName = "Samsung",
                Price = 1300,
                Rating = 4.2m,
                IsActive= true,
            });
        }
    }
}
