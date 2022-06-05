using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TopEntertainment.Application.Services;
using TopEntertainment.Domain.DTOs;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.Presentation.Controllers
{
    [ApiController]
    [Route("api/Opinions")]
    public class OpinionsController : ControllerBase
    {
        private readonly IOpinionService _serviceOpinion;
        private readonly IMapper _mapper;

        public OpinionsController(IOpinionService serviceOpinion, IMapper mapper)
        {
            _serviceOpinion = serviceOpinion;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var opinions = _serviceOpinion.GetAllOpinions();
                var opinionsMapped = _mapper.Map<List<OpinionDto>>(opinions);

                return Ok(opinionsMapped);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        public IActionResult CreateOpinion([FromBody] OpinionCreatedDto opinion)
        {
            try
            {
                var opinionEntity = _mapper.Map<Opinion>(opinion);

                if (opinionEntity != null)
                {
                    _serviceOpinion.AddOpinion(opinionEntity);

                    var OpinionDto = _mapper.Map<OpinionDto>(opinionEntity);

                    return Ok("Opinion creada");
                }

                return BadRequest("Opinion existente");
            }
            catch (Exception e)
            {
                return BadRequest("Usuario Inexistente");
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var opinion = _serviceOpinion.GetOpinionById(id);
                var opinionMapped = _mapper.Map<OpinionDto>(opinion);
                if (opinion == null)
                {
                    return NotFound("Opinion Inexistente");
                }
                return Ok(opinionMapped);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteOpinion(int id)
        {
            try
            {
                var opinion = _serviceOpinion.GetOpinionById(id);

                if (opinion == null)
                {
                    return NotFound("Opinion Inexistente");
                }

                _serviceOpinion.Delete(opinion);
                return Ok("Opinion eliminada");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
