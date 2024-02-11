using Application.BusinessLogic;
using Application.Contracts.Persistence;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.Extensions
{
    public static  class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationServices(this  IServiceCollection services)
        {
            var assembly = typeof(ApplicationExtensions).Assembly;

            services.AddMediatR(configuration =>
                configuration.RegisterServicesFromAssembly(assembly));

            services.AddValidatorsFromAssembly(assembly);

            //Ajout du service autoMapper à la collection des services 
            services.AddAutoMapper(Assembly.GetExecutingAssembly());


            // Ajout des Service pour le DInjection
            services.AddScoped<IProductService, ProductBL>();

            return services;
        }
    }
}
