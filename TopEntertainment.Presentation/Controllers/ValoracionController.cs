using Microsoft.AspNetCore.Mvc;

namespace TopEntertainment.Presentation.Controllers
{
    [ApiController]
    [Route("api/valorationss")]
    public class ValoracionController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateOpinion([FromBody] UserDto usuario)
        {
            try
            {
                var usuarioCreado = _service.CreateUser(usuario);

                if (usuarioCreado != null)
                {
                    var userCreado = _mapper.Map<UserDto>(usuarioCreado);
                    return Created("Usuario/", userCreado);
                }

                return BadRequest();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateValoration([FromBody] UserDto usuario)
        {
            try
            {
                var usuarioCreado = _service.CreateUser(usuario);

                if (usuarioCreado != null)
                {
                    var userCreado = _mapper.Map<UserDto>(usuarioCreado);
                    return Created("Usuario/", userCreado);
                }

                return BadRequest();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
