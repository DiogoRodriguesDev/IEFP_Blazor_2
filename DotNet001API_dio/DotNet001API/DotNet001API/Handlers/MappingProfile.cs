using AutoMapper;

namespace DotNet001API.Handlers
{

    public class ProductsMappingProfile : Profile
    {
        public ProductsMappingProfile()
        {
            CreateMap<DotNet001API.Models.Product, DotNet001API.Models.Product >()
                .ForMember(dest => dest.Id, dest => dest.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, dest => dest.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, dest => dest.MapFrom(src => src.Description))
                .ForMember(dest => dest.Category, dest => dest.MapFrom(src => src.Category))
                .ForMember(dest => dest.Price, dest => dest.MapFrom(src => src.Price))
                .ForMember(dest => dest.IsDeleted, dest => dest.MapFrom(src => src.IsDeleted));
        }
    }
}
