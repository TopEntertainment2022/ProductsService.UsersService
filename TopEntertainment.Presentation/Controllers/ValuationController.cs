using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TopEntertainment.Application.Services;
using TopEntertainment.Domain.DTOs;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.Presentation.Controllers
{
    [ApiController]
    [Route("api/Valuations")]
    public class ValuationController : Controller
    {
        private readonly IValuationService _serviceValuation;
        private readonly IMapper _mapper;

        public ValuationController(IValuationService serviceValuation, 
            IMapper mapper)
        {
            _mapper = mapper;
            _serviceValuation = serviceValuation;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var valuations = _serviceValuation.GetAllValuations();
                var valuationsMapped = _mapper.Map<List<ValuationDto>>(valuations);

                return Ok(valuationsMapped);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateValuation([FromBody] ValuationDto valuation)
        {
            try
            {
                var valuationEntity = _mapper.Map<Valuation>(valuation);

                if (valuationEntity != null)
                {
                    _serviceValuation.Add(valuationEntity);
                    var OpinionDto = _mapper.Map<ValuationDto>(valuationEntity);
                    return Ok("Created Valuation");
                }

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
                var valuation = _serviceValuation.GetValuationsById(id);
                var valuationMapped = _mapper.Map<ValuationDto>(valuation);
                if (valuation == null)
                {
                    return NotFound();
                }
                return Ok(valuationMapped);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteValuation(int id)
        {
            try
            {
                var valuation = _serviceValuation.GetValuationsById(id);

                if (valuation == null)
                {
                    return NotFound();
                }

                _serviceValuation.Delete(valuation);
                return Ok("valoracion eliminada");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
        
