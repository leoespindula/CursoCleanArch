using AutoMapper;
using CleanArchMvc.Aplication.DTOs;
using CleanArchMvc.Domain.Entities;

namespace CleanArchMvc.Aplication.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
