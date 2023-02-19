using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniveraStoreCase.Entities.DTOs.ResponseDtos;

namespace UniveraStoreCase.Business.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ProductResponseDto>> GetAllProducts();

        Task<List<ProductResponseDto>> GetProductsByCategories();

    }
}
