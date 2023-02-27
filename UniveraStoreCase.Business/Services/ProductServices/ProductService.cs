using AutoMapper;
using UniveraStoreCase.DataAccess.Repositories.IRepositories;
using UniveraStoreCase.Entities.DTOs.RequestDtos;
using UniveraStoreCase.Entities.DTOs.ResponseDtos;
using UniveraStoreCase.Entities.Entities;

namespace UniveraStoreCase.Business.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ProductResponseDto>> GetAllProducts()
        {
            var product = await _repository.GetAllAsync();
            var productResponse = _mapper.Map<List<ProductResponseDto>>(product);
            return productResponse;
        }

        public async Task<ProductResponseDto> GetProductById(int id)
        {
            var product = await _repository.GetEntityByIdAsync(id);
            var productResponse = _mapper.Map<ProductResponseDto>(product);
            return productResponse;
        }

        public void CreateProduct(ProductRequestDto productRequestDto)
        {
            var product = _mapper.Map<Product>(productRequestDto);
            _repository.Add(product);
            _repository.Save();
        }
        public void UpdateProduct(ProductResponseDto productResponseDto)
        {
            var product = _mapper.Map<Product>(productResponseDto);
            _repository.Update(product);
            _repository.Save();
        }
        public void DeleteProduct(int id)
        {
            _repository.Remove(id);
            _repository.Save();
        }
    }
}
