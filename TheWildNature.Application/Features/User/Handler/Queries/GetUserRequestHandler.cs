using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Repositories.UserRepository;
using TheWildNature.Application.Dtos.User;
using TheWildNature.Application.Exceptions;
using TheWildNature.Application.Features.User.Request.Queries;

namespace TheWildNature.Application.Features.User.Handler.Queries
{
    public class GetUserRequestHandler : IRequestHandler<GetUserRequest, UserDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public GetUserRequestHandler(IUserRepository userRepository, IMapper mapper)
        {
                _userRepository = userRepository;
                _mapper = mapper;
        }
        public async Task<UserDto> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.Id);
            if (user == null)
            {
                throw new NotFoundException(nameof(user), request.Id);
            }

            return _mapper.Map<UserDto>(user);
        }
    }
}
