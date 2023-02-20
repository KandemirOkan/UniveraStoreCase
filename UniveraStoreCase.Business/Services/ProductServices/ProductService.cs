using AutoMapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        async Task<List<ProductResponseDto>> IProductService.GetAllProducts()
        {
            var product = await _repository.GetAllAsync();
            var productResponse = _mapper.Map<List<ProductResponseDto>>(product);
            return productResponse;
        }

        async Task<ProductResponseDto> IProductService.GetProductById(int id)
        {
            var product = await _repository.GetEntityByIdAsync(id);
            var productResponse = _mapper.Map<ProductResponseDto>(product);
            return productResponse;
        }

        public async Task<List<ProductResponseDto>> GetProductsByCategories(int BrandId, int ColorId, int FuelTypeId, int VehicleTypeId, int YearId)
        {
            var products = await _repository.GetProductByCategory(BrandId, ColorId, FuelTypeId, VehicleTypeId, YearId);
            var productsResponse = _mapper.Map<List<ProductResponseDto>>(products);
            return productsResponse;
        }

        public void CreateProduct(ProductRequestDto productRequestDto)
        {
            var product = _mapper.Map<Product>(productRequestDto);
            _repository.Add(product);
            _repository.Save();
        }
        public void UpdateProduct(ProductRequestDto productRequestDto)
        {
            var product = _mapper.Map<Product>(productRequestDto);
            _repository.Update(product);
            _repository.Save();
        }


    }
}
