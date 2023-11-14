using AutoMapper;
using PassagensService.Dtos;
using PassagensService.Models;

namespace PassagensService.Profiles
{
    public class PassagensProfiles : Profile
    {
        public PassagensProfiles()
        {
            CreateMap<Passagens, PassagensReadDto>();
            CreateMap<PassagensCreateDto, Passagens>();
        }
    }
}
