using Modules.Products.Contracts;
using Modules.Products.DTOs;
using Modules.Products.Extensions;

namespace Modules.Products.Services
{
    public class ProductService(IProductRepository productRepository)
    {
        public List<ProductDTO> GetAllProducts()
        {
            return [.. productRepository
                .GetAllProducts()
                .Select(p => p.ToDto())];
        }
    }
}
