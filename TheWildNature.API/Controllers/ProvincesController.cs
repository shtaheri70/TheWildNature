using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheWildNature.Application.Dtos.City;
using TheWildNature.Application.Features.City.Request.Commands;
using TheWildNature.Application.Features.City.Request.Queries;

namespace TheWildNature.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvincesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProvincesController(IMediator mediator)
        {
            this._mediator = mediator;
        }
       
    }
}
