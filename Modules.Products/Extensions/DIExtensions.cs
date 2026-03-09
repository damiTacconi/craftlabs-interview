using Microsoft.Extensions.DependencyInjection;
using Modules.Products.Services;

namespace Modules.Products.Extensions
{
    public static class DIExtensions
    {
        public static IServiceCollection AddProductModule(this IServiceCollection services)
        {
            services.AddScoped<ProductService>();
            // Register product module services here
            return services;
        }
    }
}
