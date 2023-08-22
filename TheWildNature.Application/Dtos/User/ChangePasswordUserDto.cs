using TheWildNature.Application.Dtos.Common;

namespace TheWildNature.Application.Dtos.User
{
    public class ChangePasswordUserDto:BaseDto
    {
        public string Password { get; set; }
        public string RePassword { get; set; }
    }
}
