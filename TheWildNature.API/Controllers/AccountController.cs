using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheWildNature.Application.Dtos.User;
using TheWildNature.Application.Features.User.Request.Commands;
using TheWildNature.Application.Features.User.Request.Queries;

namespace TheWildNature.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // POST api/<UsersController>
        [HttpPost("ActiveAccount")]
        public async Task<ActionResult<bool>> ActiveAccount([FromBody] string ActiveCode)
        {
            var command = new ActiveAccountCommand { ActiveCode = ActiveCode };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<bool>> Login([FromBody] LoginUserDto loginUser)
        {
            var command = new LoginUserRequest { LoginUserDto = loginUser };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        //[HttpPost]
        //public ActionResult Login([FromBody] UserLoginDto userLogin)
        //{
        //    var user = Authenticate(userLogin);
        //    if (user != null)
        //    {
        //        var token = GenerateToken(user);
        //        return Ok(token);
        //    }

        //    return NotFound("user not found");
        //}

    }
}
