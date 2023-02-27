using AutoMapper;
using UniveraStoreCase.DataAccess.Repositories.IRepositories;
using UniveraStoreCase.Entities.DTOs.RequestDtos;
using UniveraStoreCase.Entities.DTOs.ResponseDtos;
using UniveraStoreCase.Entities.Entities;

namespace UniveraStoreCase.Business.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<CategoryResponseDto>> GetAllCategories()
        {
            var category = await _repository.GetAllAsync();
            var categoryResponse = _mapper.Map<List<CategoryResponseDto>>(category);
            return categoryResponse;
        }
        public IEnumerable<ProductResponseDto> GetProductByCategoryId(int categoryId)
        {
            var products = _repository.GetProductByCategory(categoryId);
            return products;
        }

        public void CreateCategory(CategoryRequestDto categoryRequestDto)
        {
            var category = _mapper.Map<Category>(categoryRequestDto);
            _repository.Add(category);
            _repository.Save();
        }
        public void UpdateCategory(CategoryResponseDto categoryResponseDto)
        {
            var category = _mapper.Map<Category>(categoryResponseDto);
            _repository.Update(category);
            _repository.Save();
        }
        public void DeleteCategory(int id)
        {
            _repository.Remove(id);
            _repository.Save();
        }
    }
}
