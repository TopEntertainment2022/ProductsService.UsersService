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
                var usuario = _service.GetAll();
                var usuarioMapped = _mapper.Map<List<UserDto>>(usuario);
                if (usuario == null)
                {
                    return NotFound();
                }

                return Ok(usuarioMapped);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var usuario = _service.GetUserById(id);
                var usuarioMapped = _mapper.Map<UserDto>(usuario);

                if (usuario == null)
                {
                    return NotFound();
                }

                return Ok(usuarioMapped);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }

        }
        [HttpPost]
        public async Task<IActionResult> Post(UserDto UserDto)
        {
            try
            {
                var userCreado = _mapper.Map<User>(UserDto);
                var usuarioCreado = _service.InsertUser(UserDto);

                if (usuarioCreado != null)
                {
                    return Created("Usuario/", userCreado);
                }
                return BadRequest();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(UserDto userDto)
        {
            try
            {
                var usuario = _service.GetUserById(userDto.UserId);
                if (usuario==null)
                {
                    return NotFound();
                }
                _mapper.Map(userDto, usuario);
                _service.UpdateUser(usuario);
                return Ok(usuario);
            }
            catch (Exception)
            {

                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var usuario = _service.GetUserById(id);

                if (usuario == null)
                {
                    return NotFound();
                }

                _service.DeleteUser(usuario);
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
