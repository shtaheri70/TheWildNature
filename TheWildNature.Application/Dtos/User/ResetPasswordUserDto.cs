namespace TheWildNature.Application.Dtos.User
{
    public class ResetPasswordUserDto
    {
        public string ActiveCode { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
    }
}
