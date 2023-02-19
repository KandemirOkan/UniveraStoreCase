using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniveraStoreCase.DataAccess.Repositories.IRepositories;
using UniveraStoreCase.Entities.DTOs.ResponseDtos;

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
            var products = await _repository.GetAllAsync();
            var productResponse = _mapper.Map<List<ProductResponseDto>>(products);
            return productResponse;
        }

        public async Task<List<ProductResponseDto>> GetProductsByCategories()
        {
            var products = await _repository.GetProductByCategory();
            var productsResponse = _mapper.Map<List<ProductResponseDto>>(products);
            return productsResponse;
        }
    }
}
