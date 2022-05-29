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
                    return Ok("Created Opinion");
                }
                //var opinionCreada = _serviceOpinion.AddOpinion(opinion);

                //if (opinionCreada != null)
                //{
                //    var userCreado = _mapper.Map<OpinionDto>(opinionCreada);
                //    return Created("Usuario/", userCreado);
                //}

                return BadRequest();
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
                var opinion = _serviceOpinion.GetOpinionById(id);
                var opinionMapped = _mapper.Map<OpinionDto>(opinion);
                if (opinion == null)
                {
                    return NotFound();
                }
                return Ok(opinionMapped);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{Id}")]
        public IActionResult GetOpinionUserId(int id)
        {
            try
            {
                var opinion = _serviceOpinion.GetOpinionsByUserId(id);
                var opinionMapped = _mapper.Map<List<OpinionDto>>(opinion);
                
                return Ok(opinionMapped);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult UpdateOpinion(int id, OpinionUpdateDto opinion)
        {
            try
            {
                if (opinion == null)
                {
                    return BadRequest("Completar todos los campos para realizar la actualizacion");
                }

                var opinionUpdate = _serviceOpinion.GetOpinionById(id);

                if (opinionUpdate == null)
                {
                    return NotFound();
                }

                _mapper.Map(opinion, opinionUpdate);
                _serviceOpinion.Update(opinionUpdate);

                return Ok("Actualizado");
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
                    return NotFound();
                }

                _serviceOpinion.Delete(opinion);
                return Ok("opinion eliminado");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //[HttpPost]
        //public IActionResult CreateValoration([FromBody] UserDto usuario)
        //{
        //    try
        //    {
        //        var usuarioCreado = _service.CreateUser(usuario);

        //        if (usuarioCreado != null)
        //        {
        //            var userCreado = _mapper.Map<UserDto>(usuarioCreado);
        //            return Created("Usuario/", userCreado);
        //        }

        //        return BadRequest();
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest(e.Message);
        //    }
        //}
    }
}
