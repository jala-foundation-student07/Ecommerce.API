using AutoMapper;
using Ecommerce.API.ModelsDto;
using Ecommerce.Models.Entities;

namespace Ecommerce.API.Mappings
{
    public class CommonProfile : Profile
    {
        public CommonProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
        }
    }
}
