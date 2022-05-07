using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TopEntertainment.Application.Services;
using TopEntertainment.Domain.DTOs;
using TopEntertainment.Domain.Entities;

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
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return NoContent();
            }
        }

        [HttpGet("{id}")]
         async Task<IActionResult> Get(int id)
        {
            try
            {
                var usuario = _service.GetUserById(id);
                var usuarioMapped = _mapper.Map<UserDto>(User);
                if(usuario == null)
                {
                    return NotFound();
                }

                return Ok(usuarioMapped);
            }
            catch (Exception e)
            {
                return NoContent();
            }
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
