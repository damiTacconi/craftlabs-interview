using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Modules.Products.DTOs;
using Modules.Products.Services;

namespace Products.WebAPI.Controllers
{
    [DisableCors]
    [ApiController]
    [Route("api/products")]
    [Produces("application/json")]
    public class ProductController(ProductService service) : ControllerBase
    {
        [DisableCors]
        [HttpGet]
        public ActionResult<List<ProductDTO>> GetAllProducts()
        {
            var products = service.GetAllProducts();
            return Ok(products);
        }
    }
}
