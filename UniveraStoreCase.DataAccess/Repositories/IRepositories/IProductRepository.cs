using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniveraStoreCase.Entities.DTOs.ResponseDtos;
using UniveraStoreCase.Entities.Entities;

namespace UniveraStoreCase.DataAccess.Repositories.IRepositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<List<ProductResponseDto>> GetProductByCategory(int BrandId, int ColorId, int FuelTypeId, int VehicleTypeId, int YearId);
    }
}
