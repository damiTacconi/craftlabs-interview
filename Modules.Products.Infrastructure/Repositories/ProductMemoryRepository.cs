using Modules.Products.Contracts;

namespace Modules.Products.Infrastructure.Repositories
{
    public class ProductMemoryRepository : IProductRepository
    {
        private List<Product> _products = new()
        {
            new Product("PC", 20.0m),
            new Product("Notebook", 40.0m),
            new Product("Macbook", 1000.0m),
        };

        public List<Product> GetAllProducts()
        {
            return _products;
        }
    }
}
