using MediatR;
using TheWildNature.Application.Dtos.User;

namespace TheWildNature.Application.Features.User.Request.Queries
{
    public class GetUserRequest:IRequest<UserDto>
    {
        public int Id { get; set; }
    }
}
