using MediatR;
using TheWildNature.Application.Dtos.User;

namespace TheWildNature.Application.Features.User.Request.Queries
{
    public class LoginUserRequest:IRequest<string>
    {
        public LoginUserDto LoginUserDto { get; set; }
    }
}
