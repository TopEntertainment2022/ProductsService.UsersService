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
        public IActionResult CreateOpinion([FromBody] OpinionDto opinion)
        {
            try
            {
                var opinionEntity = _mapper.Map<Opinion>(opinion);

                if (opinionEntity != null)
                {
                    _serviceOpinion.AddOpinion(opinionEntity);
                    var OpinionDto = _mapper.Map<OpinionDto>(opinionEntity);                  
                    return Created("Usuario/", OpinionDto);
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
