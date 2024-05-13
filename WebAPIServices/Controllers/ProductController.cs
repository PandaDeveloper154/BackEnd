using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIServices.Services.ProductServices;
using WebAPIServices.Services.SuperHeroService;

namespace WebAPIServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {

            return _productService.GetAllProducts();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetSingleProduct(int id)
        {
            var result = _productService.GetSingleProduct(id);
            if (result is null)
                return NotFound("Product not found");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Product>>> AddProduct(Product product)
        {
            var result = _productService.AddProduct(product);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Product>>> UpdateProduct(int id, Product request)
        {
            var result = _productService.UpdateProduct(id, request);
            if (result is null)
                return NotFound("Product not found");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Product>>> DeleteHero(int id)
        {
            var result = _productService.DeleteProduct(id);
            if (result is null)
                return NotFound("Product not found");
            return Ok(result);
        }
    }
}

