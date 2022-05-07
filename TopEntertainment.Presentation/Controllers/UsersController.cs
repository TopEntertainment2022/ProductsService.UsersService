using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TopEntertainment.Application.Services;
using TopEntertainment.Domain.DTOs;

namespace TopEntertainment.Presentation.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUsuarioService _service;
        private readonly IMapper _mapper;

        public UsersController(IUsuarioService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {         
            var usuario = _service.GetAll();
            var usuarioMapped = _mapper.Map<List<UserDto>>(usuario);

            return Ok(usuarioMapped);         
        }

        [HttpGet("{id}")]
         public async Task<IActionResult> Get(int id)
         { 
             var usuario = _service.GetUserById(id);
             var usuarioMapped = _mapper.Map<UserDto>(usuario);
             if(usuario == null)
             {
                return NotFound();
             }

             return Ok(usuarioMapped);
         }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return NoContent();
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return NoContent();
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return NoContent();
            }
        }

    }
}
