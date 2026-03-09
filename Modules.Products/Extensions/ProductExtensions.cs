using Modules.Products.DTOs;

namespace Modules.Products.Extensions
{
    public static class ProductExtensions
    {
        extension(Product product)
        {
            public ProductDTO ToDto()
            {
                return new ProductDTO(product.Id, product.Name, product.Price);
            }
        }
    }
}
