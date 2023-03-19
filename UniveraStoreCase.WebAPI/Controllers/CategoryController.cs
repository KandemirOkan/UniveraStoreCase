using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using UniveraStoreCase.Business.Services.CategoryServices;
using UniveraStoreCase.Entities.DTOs.RequestDtos;
using UniveraStoreCase.Entities.DTOs.ResponseDtos;

namespace UniveraStoreCase.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            var categories = await _categoryService.GetAllCategories();
            return Ok(categories);
        }

        [HttpGet("[action]")]
        public IActionResult GetProductByCategoryId(int categoryId)
        {
            var product = _categoryService.GetProductByCategoryId(categoryId);
            return Ok(product);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost("[action]")]
        public IActionResult CreateCategory([FromBody] CategoryRequestDto newCategory)
        {
            _categoryService.CreateCategory(newCategory);
            return Ok();

        }
        [Authorize(Roles = "Admin")]
        [HttpPut("[action]")]
        public IActionResult UpdateCategory([FromBody] CategoryResponseDto newCategory)
        {
            _categoryService.UpdateCategory(newCategory);
            return Ok();
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete("[action]/{categoryId}")]
        public IActionResult DeleteProduct(int categoryId)
        {
            _categoryService.DeleteCategory(categoryId);
            return Ok();
        }
    }
}
