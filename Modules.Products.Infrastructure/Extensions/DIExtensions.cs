using Microsoft.Extensions.DependencyInjection;
using Modules.Products.Contracts;
using Modules.Products.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.Products.Infrastructure.Extensions
{
    public static class DIExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            // Register infrastructure services here
            services.AddScoped<IProductRepository, ProductMemoryRepository>();
            return services;
        }
    }
}
