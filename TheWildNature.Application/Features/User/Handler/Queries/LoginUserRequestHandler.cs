using AutoMapper;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TheWildNature.Application.Contracts.Repositories.UserRepository;
using TheWildNature.Application.Exceptions;
using TheWildNature.Application.Features.User.Request.Queries;

namespace TheWildNature.Application.Features.User.Handler.Queries
{
    public class LoginUserRequestHandler : IRequestHandler<LoginUserRequest, string>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public LoginUserRequestHandler(IUserRepository userRepository
                                          , IMapper mapper
                                          , IConfiguration configuration)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<string> Handle(LoginUserRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<TheWildNature.Domain.Entities.Users.User>(request.LoginUserDto);

            user = await _userRepository.Authenticate(user.Mobile, user.Password);

            if (user == null)
            {
                throw new NotFoundException(nameof(user), request.LoginUserDto.Mobile);
            }

            //Generate token
            var tokenToReturn = GenerateToken(user);


            return tokenToReturn;
        }
        private string GenerateToken(TheWildNature.Domain.Entities.Users.User user)
        {
            var securityKey = new SymmetricSecurityKey(
                Encoding.ASCII.GetBytes(_configuration["Authentication:SecretForKey"])
                );
            var signingCredentials = new SigningCredentials(
                securityKey, SecurityAlgorithms.HmacSha256
                );
            var claimsForToken = new List<Claim>();
            claimsForToken.Add(new Claim("UserId", user.Id.ToString()));
            claimsForToken.Add(new Claim("UserMobile", user.Mobile));

            var jwtSecurityToke = new JwtSecurityToken(
                _configuration["Authentication:Issuer"],
                _configuration["Authentication:Audience"],
                claimsForToken,
                DateTime.Now,
                DateTime.Now.AddHours(1),
                signingCredentials
                );

            var tokenToReturn = new JwtSecurityTokenHandler()
                .WriteToken(jwtSecurityToke);

            return tokenToReturn;
        }
    }
}
