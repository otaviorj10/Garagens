using AutoMapper;
using GaragensService.Dtos;
using GaragensService.Models;
using GaragensService.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GaragensService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaragensController : Controller
    {
        private readonly IGaragensRepository _repository;
        private readonly IMapper _mapper;

        public GaragensController(IGaragensRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<GaragensReadDto>> GetAllGaragens()
        {

            var garagens = _repository.GetAllGaragens();

            return Ok(_mapper.Map<IEnumerable<GaragensReadDto>>(garagens));
        }

        [HttpGet("{id}", Name = "GetGaragensById")]
        public ActionResult<GaragensReadDto> GetGaragensById(int id)
        {
            var garagens = _repository.GetGaragensById(id);
            if (garagens != null)
            {
                return Ok(_mapper.Map<GaragensReadDto>(garagens));
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<GaragensCreateDto>> CreateRestaurante([FromBody] GaragensCreateDto garagenCreateDto)
        {
            var restaurante = _mapper.Map<Garagens>(garagenCreateDto);
            _repository.CreateGaragens(restaurante);
            _repository.SaveChanges();

            var garagensReadDto = _mapper.Map<GaragensReadDto>(restaurante);

            return CreatedAtRoute(nameof(GetGaragensById), new { garagensReadDto.IdGaragens }, garagensReadDto);
        }

    }
}
