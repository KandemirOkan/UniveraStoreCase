using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using UniveraStoreCase.Business.Services.ProductServices;
using UniveraStoreCase.Entities.DTOs.RequestDtos;
using UniveraStoreCase.Entities.Entities;

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
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _productService.GetProductById(id);
            return Ok(product);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductByCategories(int BrandId, int ColorId, int FuelTypeId, int VehicleTypeId, int YearId)
        {
            var product = await _productService.GetProductsByCategories(BrandId,ColorId,FuelTypeId,VehicleTypeId,YearId);
            return Ok(product);
        }

        [HttpPost("[action]")]
        public IActionResult CreateProduct([FromBody] ProductRequestDto newProduct)
        {
            _productService.CreateProduct(newProduct);
            return Ok();
            
        }

        [HttpPut("[action]")]
        public IActionResult UpdateProduct([FromBody] ProductRequestDto newProduct)
        {
            _productService.UpdateProduct(newProduct);
            return Ok();
        }
    }
}
