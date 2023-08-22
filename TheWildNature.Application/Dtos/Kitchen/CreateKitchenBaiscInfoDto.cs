using TheWildNature.Application.Dtos.User;

namespace TheWildNature.Application.Dtos.Kitchen
{
    public class CreateKitchenBaiscInfoDto: IKitchenDto, IUserDto,IUserFullNameDto
    {
        public string KitchenName { get; set; }
        public int BusinessTypeId { get; set; }
        public int CityId { get; set; }
        public string Mobile { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        
    }
}
