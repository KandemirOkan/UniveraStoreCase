using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UniveraStoreCase.DataAccess.Data;
using UniveraStoreCase.DataAccess.Repositories.GenericRepositories;
using UniveraStoreCase.DataAccess.Repositories.IRepositories;
using UniveraStoreCase.Entities.DTOs.ResponseDtos;
using UniveraStoreCase.Entities.Entities;

namespace UniveraStoreCase.DataAccess.Repositories.EfCoreRepositories
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly UniveraDbContext _context;

        private IMapper _mapper;

        public EfCategoryRepository(UniveraDbContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<ProductResponseDto> GetProductByCategory(int categoryId)
        {
            var result =
                from Product in _context.Product
                join ProductCategory in _context.ProductCategory
                on Product.Id equals ProductCategory.ProductId
                join Category in _context.Category
                on ProductCategory.CategoryId equals Category.Id
                where ProductCategory.CategoryId == categoryId
                select new ProductResponseDto
                {
                    Id = Product.Id,
                    Name = Product.Name,
                    Price = Product.Price,
                    Description = Product.Description,
                    ModelYear= Product.ModelYear,
                    
                };
            return result;
        }
    }
}
