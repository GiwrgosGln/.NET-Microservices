using AutoMapper;
using MicroserviceA.Dtos;
using MicroserviceA.Models;

namespace MicroserviceA.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source -> Target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}