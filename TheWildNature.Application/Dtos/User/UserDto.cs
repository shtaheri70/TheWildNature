using TheWildNature.Application.Dtos.Common;

namespace TheWildNature.Application.Dtos.User
{
    public class UserDto:BaseDto
    {
        public string Mobile { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        //public bool IsActive { get; set; }
    }
}
