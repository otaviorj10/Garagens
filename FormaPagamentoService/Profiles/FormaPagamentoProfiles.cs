using AutoMapper;
using FormaPagamentoService.Dtos;
using FormaPagamentoService.Models;

namespace FormaPagamentoService.Profiles
{
    public class FormaPagamentoProfiles : Profile
    {
        public FormaPagamentoProfiles()
        {
            CreateMap<FormasPagamento, FormasPagamentoReadDto>();
            CreateMap<FormasPagamentoCreateDto, FormasPagamento>();
        }
    }
}
