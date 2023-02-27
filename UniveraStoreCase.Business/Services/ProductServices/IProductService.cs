using UniveraStoreCase.Entities.DTOs.RequestDtos;
using UniveraStoreCase.Entities.DTOs.ResponseDtos;

namespace UniveraStoreCase.Business.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ProductResponseDto>> GetAllProducts();
        Task<ProductResponseDto> GetProductById(int id);
        public void CreateProduct(ProductRequestDto productRequestDto);
        public void UpdateProduct(ProductResponseDto productResponseDto);
        public void DeleteProduct(int id);
    }
}
