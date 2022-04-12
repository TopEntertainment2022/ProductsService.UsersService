using Microsoft.AspNetCore.Mvc;
using TopEntertainment.Domain.DTOs;

namespace TopEntertainment.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class NamesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetNames()
        {
            throw new NotImplementedException();
        }
    }
}
