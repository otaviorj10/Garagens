using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PassagensService.Dtos;
using PassagensService.Models;
using PassagensService.Repository;

namespace PassagensService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassagemController : Controller
    {
        private readonly IPassagensRepository _repository;
        private readonly IMapper _mapper;

        public PassagemController(IPassagensRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PassagensReadDto>> GetAllPassagens()
        {

            var passagens = _repository.GetAllPassagens();

            return Ok(_mapper.Map<IEnumerable<PassagensReadDto>>(passagens));
        }

        [HttpGet("{id}", Name = "GetPassagensById")]
        public ActionResult<PassagensReadDto> GetPassagensById(int id)
        {
            var passagens = _repository.GetPassagensById(id);
            if (passagens != null)
            {
                return Ok(_mapper.Map<PassagensReadDto>(passagens));
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<PassagensCreateDto>> CreatePassagens([FromBody] PassagensCreateDto passagensCreateDto)
        {
            var passagens = _mapper.Map<Passagens>(passagensCreateDto);
            _repository.CreatePassagens(passagens);
            _repository.SaveChanges();

            var passagensReadDto = _mapper.Map<PassagensReadDto>(passagens);

            return CreatedAtRoute(nameof(GetPassagensById), new { id = passagensReadDto.IdGaragens }, passagensReadDto);
        }
    }
}
