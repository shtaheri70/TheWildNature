namespace TheWildNature.Application.Dtos.User
{
    public class RegisterFullNameUserDto: IUserFullNameDto
    {
        public string Name { get; set; }
        public string Family { get; set; }
    }
}
