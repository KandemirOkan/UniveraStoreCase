using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Drawing;
using UniveraStoreCase.Business.Services.ProductServices;
using UniveraStoreCase.Entities.DTOs.RequestDtos;
using UniveraStoreCase.Entities.DTOs.ResponseDtos;

namespace UniveraStoreCase.WebAPI.Controllers
{
    [Authorize]
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


        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductById(int productId)
        {
            var product = await _productService.GetProductById(productId);
            return Ok(product);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost("[action]")]
        public IActionResult CreateProduct([FromBody] ProductRequestDto newProduct)
        {
            _productService.CreateProduct(newProduct);
            return Ok();
            
        }
        [Authorize(Roles = "Admin")]
        [HttpPut("[action]")]
        public IActionResult UpdateProduct([FromBody] ProductResponseDto newProduct)
        {
            _productService.UpdateProduct(newProduct);
            return Ok();
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete("[action]/{productId}")]
        public IActionResult DeleteProduct(int productId)
        {
            _productService.DeleteProduct(productId);
            return Ok();
        }
    }
}
