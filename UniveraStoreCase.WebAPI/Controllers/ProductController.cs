using Microsoft.AspNetCore.Mvc;
using UniveraStoreCase.Business.Services.ProductServices;

namespace UniveraStoreCase.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllProductsAsync()
        {
            var products = await _productService.GetAllProducts();
            return Ok(products);
        }


        [HttpGet("[action]/{productId}")]
        public string Get(int id)
        {
            return "value";
        }


        [HttpPost("[action]")]
        public void Post([FromBody] string value)
        {
        }


        [HttpPut("[action]")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("[action]")]
        public void Delete(int id)
        {
        }
    }
}
