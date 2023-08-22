namespace TheWildNature.Application.Dtos.User
{
    public class ListUserDto
    {
        public  List<UserDto> UserDtos { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }

    }
}
