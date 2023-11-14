using AutoMapper;
using GaragensService.Dtos;
using GaragensService.Models;

namespace GaragensService.Profiles
{
    public class GaragensProfiles : Profile
    {
        public GaragensProfiles()
        {
            CreateMap<Garagens, GaragensReadDto>();
            CreateMap<GaragensCreateDto, Garagens>();
        }
    }
}
