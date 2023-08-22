using AutoMapper;
using TheWildNature.Application.Dtos.User;
using TheWildNature.Domain.Entities.Users;

namespace TheWildNature.Application.Profiles
{
    public class MappingProfileUser:Profile
    {
        public MappingProfileUser()
        {
            CreateMap<User, ActiveCodeUserDto>(MemberList.None).ReverseMap();
            CreateMap<User, ChangePasswordUserDto>(MemberList.None).ReverseMap();
            CreateMap<User, LoginUserDto>(MemberList.None).ReverseMap();
            CreateMap<User, UserDto>(MemberList.None).ReverseMap();
        }
    }
}
