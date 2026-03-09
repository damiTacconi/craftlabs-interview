namespace Modules.Products
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
