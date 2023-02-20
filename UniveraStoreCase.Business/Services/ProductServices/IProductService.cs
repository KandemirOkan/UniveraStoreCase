using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniveraStoreCase.Entities.DTOs.RequestDtos;
using UniveraStoreCase.Entities.DTOs.ResponseDtos;

namespace UniveraStoreCase.Business.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ProductResponseDto>> GetAllProducts();

        Task<List<ProductResponseDto>> GetProductsByCategories(int BrandId, int ColorId, int FuelTypeId, int VehicleTypeId, int YearId);

        Task<ProductResponseDto> GetProductById(int id);

        public void CreateProduct(ProductRequestDto productRequestDto);
        public void UpdateProduct(ProductRequestDto productRequestDto);

    }
}
