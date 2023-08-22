using MediatR;
using TheWildNature.Application.Contracts.Repositories.UserRepository;
using TheWildNature.Application.Features.User.Request.Queries;

namespace TheWildNature.Application.Features.User.Handler.Queries
{
    public class IsExistUserWithMobileRequestHandler : IRequestHandler<IsExistUserWithMobileRequest, bool>
    {
        private readonly IUserRepository _userRepository;
        public IsExistUserWithMobileRequestHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> Handle(IsExistUserWithMobileRequest request, CancellationToken cancellationToken)
        {
            return await _userRepository.IsExistUserWithMobile(request.Mobile);
        }
    }
}
