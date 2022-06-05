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
        public IActionResult GetAll()
        {
            try
            {
                var usuario = _service.GetAll();
                var usuarioMapped = _mapper.Map<List<UserDto>>(usuario);

                return Ok(usuarioMapped);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
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
                    return NotFound("Usuario Inexistente");
                }
                return Ok(usuarioMapped);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateUser([FromForm] UserDto usuario)
        {
            try
            {
                var usuarioEntidad = _service.CreateUser(usuario);

                if (usuarioEntidad != null)
                {
                    var userCreado = _mapper.Map<UserDto>(usuarioEntidad);
                    return Ok("Usuario creado");
                }

                return BadRequest();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, UserDto user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest("Completar todos los campos para realizar la actualizacion");
                }

                var userUpdate = _service.GetUserById(id);

                if (userUpdate == null)
                {
                    return NotFound("Usuario Inexistente");
                }

                _mapper.Map(user, userUpdate);
                _service.Update(userUpdate);

                return Ok("Usuario actualizado");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                var usuario = _service.GetUserById(id);

                if (usuario == null)
                {
                    return NotFound("Usuario Inexistente");
                }

                _service.Delete(usuario);
                return Ok("Usuario eliminado");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
