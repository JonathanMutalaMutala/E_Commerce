using Application.Contracts.Persistence;
using Domain.InterfacesRepository;
using Emp.Persistence.DatabaseContext;
using Emp.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<EcommerceContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("EcommerceConnectionString"));
            });

            services.AddScoped<IProductRepository, ProductRepository>();

            return services; 
        }
    }
}
