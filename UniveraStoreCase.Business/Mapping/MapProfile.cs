using AutoMapper;
using UniveraStoreCase.Entities.DTOs.RequestDtos;
using UniveraStoreCase.Entities.DTOs.ResponseDtos;
using UniveraStoreCase.Entities.Entities;

namespace UniveraStoreCase.Business.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<ProductRequestDto, Product>().ReverseMap();

            CreateMap<Product,ProductResponseDto>().ReverseMap();

            CreateMap<Category,CategoryResponseDto>().ReverseMap();

            CreateMap<Category,CategoryRequestDto>().ReverseMap();       

        }
    }
}
