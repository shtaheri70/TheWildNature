using MediatR;
using Microsoft.AspNetCore.Mvc;
using TheWildNature.Application.Dtos.City;
using TheWildNature.Application.Features.City.Request.Commands;
using TheWildNature.Application.Features.City.Request.Queries;

namespace TheWildNature.API.Controllers
{
    [Route("api/Cities")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CitiesController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        // GET api/<CitiessController>
        [HttpGet("{provinceId}")]
        public async Task<ActionResult<List<CityDto>>> Get(int provinceId)
        {
            var cityList = await _mediator.Send(new GetCityListRequest { ProvinceId = provinceId });
            return Ok(cityList);
        }
        // GET api/<CitiessController>/5
        [HttpGet("GetCity/{id}")]
        public async Task<ActionResult<CityDto>> GetCity(int id)
        {
            var city = await _mediator.Send(new GetCityDetailsRequest { Id = id });
            return Ok(city);
        }
        // POST api/<CitiessController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateCityDto city)
        {
            var command = new CreateCityCommand { CreateCityDto = city };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        // PUT api/<CitiessController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] CityDto city)
        {
            var command = new EditCityCommand { CityDto = city };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // DELETE api/<CitiessController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteCityCommand { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // GET api/<CitiessController>/GetProvinceList
        [HttpGet("GetProvinceList")]
        public async Task<ActionResult<List<ProvinceDto>>> GetProvinceList()
        {
            var provinceList = await _mediator.Send(new GetProvinceListRequest());
            return Ok(provinceList);
        }

      
    }
}
