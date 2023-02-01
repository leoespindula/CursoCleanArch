using AutoMapper;
using CleanArchMvc.Aplication.DTOs;
using CleanArchMvc.Aplication.Products.Commands;

namespace CleanArchMvc.Aplication.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<ProductDTO, ProductCreateCommand>();
            CreateMap<ProductDTO, ProductUpdateCommand>();
        }
    }
}
