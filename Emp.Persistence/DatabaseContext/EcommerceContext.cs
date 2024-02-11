using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Persistence.DatabaseContext
{
    public  class EcommerceContext : DbContext
    {
        private readonly DbContextOptions<EcommerceContext> _options;


        public EcommerceContext(DbContextOptions<EcommerceContext> options)
        {
            _options = options;
        }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            base.OnModelCreating(modelBuilder);
        }
    }
}
