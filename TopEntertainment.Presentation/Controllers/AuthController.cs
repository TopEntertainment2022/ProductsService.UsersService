using Microsoft.AspNetCore.Mvc;

namespace TopEntertainment.Presentation.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Post()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("Ok:False - " + ex.Message);
            }
        }
    }
}
