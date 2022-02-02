using AutoMapper;
using CommandsService.Dtos;
using CommandsService.Models;

namespace CommandsService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            //Source -> target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformPublishedDto, Platform>()
                .ForMember(dest => dest.ExternalID, opt => opt.MapFrom(src => src.Id));
        }
    }
}