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
            //Ajout du service autoMapper à la collection des services 
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
