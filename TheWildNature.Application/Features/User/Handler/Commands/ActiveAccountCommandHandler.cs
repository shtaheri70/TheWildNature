using MediatR;
using TheWildNature.Application.Contracts.Repositories.UserRepository;
using TheWildNature.Application.Features.User.Request.Commands;

namespace TheWildNature.Application.Features.User.Handler.Commands
{
    public class ActiveAccountCommandHandler : IRequestHandler<ActiveAccountCommand, bool>
    {
        private readonly IUserRepository _userRepository;
        public ActiveAccountCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> Handle(ActiveAccountCommand request, CancellationToken cancellationToken)
        {
            var IsActive = await _userRepository.ActiveAccount(request.ActiveCode);
            return IsActive;
        }
    }
}
