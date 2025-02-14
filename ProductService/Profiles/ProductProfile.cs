using AutoMapper;
using ProductService.Entities;
using ProductService.Models;

namespace ProductService.Profiles;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductDto>();
    }
}