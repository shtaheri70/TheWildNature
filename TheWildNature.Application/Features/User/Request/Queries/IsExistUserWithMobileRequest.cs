using MediatR;

namespace TheWildNature.Application.Features.User.Request.Queries
{
    public class IsExistUserWithMobileRequest:IRequest<bool>
    {
        public string Mobile { get; set; }
    }
}