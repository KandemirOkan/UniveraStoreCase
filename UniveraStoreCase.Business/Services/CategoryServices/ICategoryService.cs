using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniveraStoreCase.Entities.DTOs.RequestDtos;
using UniveraStoreCase.Entities.DTOs.ResponseDtos;

namespace UniveraStoreCase.Business.Services.CategoryServices
{
    public interface ICategoryService
    {
            Task<List<CategoryResponseDto>> GetAllCategories();
            IEnumerable<ProductResponseDto> GetProductByCategoryId(int id);
            public void CreateCategory(CategoryRequestDto categoryRequestDto);
            public void UpdateCategory(CategoryResponseDto categoryResponseDto);
            public void DeleteCategory(int id);
    }
}
