using AutoMapper;
using FormaPagamentoService.Dtos;
using FormaPagamentoService.Models;
using FormaPagamentoService.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FormaPagamentoService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormaPagamentoController : Controller
    {
        private readonly IFormasPagamentoRepository _repository;
        private readonly IMapper _mapper;

        public FormaPagamentoController(IFormasPagamentoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult<IEnumerable<FormasPagamentoReadDto>> GetAllFormasPagamento()
        {

            var garagens = _repository.GetAllFormasPagamento();

            return Ok(_mapper.Map<IEnumerable<FormasPagamentoReadDto>>(garagens));
        }

        [HttpGet("{id}", Name = "GetFormaPagamentoById")]
        public ActionResult<FormasPagamentoReadDto> GetFormaPagamentoById(int id)
        {
            var formasPagamentos = _repository.GetFormasPagamentoById(id);
            if (formasPagamentos != null)
            {
                return Ok(_mapper.Map<FormasPagamentoReadDto>(formasPagamentos));
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<FormasPagamentoCreateDto>> CreateFormasPagamento([FromBody] FormasPagamentoCreateDto formasPagamentosCreateDto)
        {
            var formasPagamento = _mapper.Map<FormasPagamento>(formasPagamentosCreateDto);
            _repository.CreateFormasPagamento(formasPagamento);
            _repository.SaveChanges();

            var formasPagamentoReadDto = _mapper.Map<FormasPagamentoReadDto>(formasPagamento);

            return CreatedAtRoute(nameof(GetFormaPagamentoById), new { id = formasPagamentoReadDto.IdFormasPagamento }, formasPagamentoReadDto);
        }
    }
}