using AutoMapper;
using Flog.Entities;
using Flog.Entity.Dto;

namespace Flog.API.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreatePostDto, Post>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
            .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author))
            .ForMember(dest => dest.PodId, opt => opt.MapFrom(src => src.PodId))
            .ForMember(dest => dest.Private, opt => opt.MapFrom(src => src.Private))
            .ForMember(dest => dest.BlockedToView, opt => opt.MapFrom(src => src.BlockedToView))
            .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags))
            .ForMember(dest => dest.Viewed, opt => opt.MapFrom(src => 0))
            .ForMember(dest => dest.Rate, opt => opt.MapFrom(src => 0));
    }
}
