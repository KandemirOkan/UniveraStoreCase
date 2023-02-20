using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniveraStoreCase.DataAccess.Data;
using UniveraStoreCase.DataAccess.Repositories.GenericRepositories;
using UniveraStoreCase.DataAccess.Repositories.IRepositories;
using UniveraStoreCase.Entities.DTOs.ResponseDtos;
using UniveraStoreCase.Entities.Entities;

namespace UniveraStoreCase.DataAccess.Repositories.EfCoreRepositories
{
    public class EfProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly UniveraDbContext _context;

        private IMapper _mapper;

        public EfProductRepository(UniveraDbContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ProductResponseDto>> GetProductByCategory(int BrandId, int ColorId, int FuelTypeId, int VehicleTypeId, int YearId)
        {
            var listProducts = await _context.Products.Where(x =>
            x.CategoryBrandId == BrandId &&
            x.CategoryColorId == ColorId &&
            x.CategoryFuelTypeId == FuelTypeId &&
            x.CategoryVehicleTypeId == VehicleTypeId &&
            x.CategoryYearId == YearId).ToListAsync();

            var listResponseDto = _mapper.Map<List<ProductResponseDto>>(listProducts);
            return listResponseDto;
        }
    }
}
