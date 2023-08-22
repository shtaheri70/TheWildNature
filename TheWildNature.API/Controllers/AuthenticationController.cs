using MediatR;
using Microsoft.AspNetCore.Mvc;
using TheWildNature.Application.Dtos.User;
using TheWildNature.Application.Features.User.Request.Queries;
using TheWildNature.Domain.Entities.Users;

namespace TheWildNature.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AuthenticationController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost("authenticate")]
        public async Task<ActionResult<User>> Authenticate([FromBody] LoginUserDto loginUser)
        {
            var command = new LoginUserRequest { LoginUserDto = loginUser };
            var user = await _mediator.Send(command);

            return Ok(user);
        }
    }
}
