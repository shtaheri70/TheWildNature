using TheWildNature.Application.Dtos.Common;

namespace TheWildNature.Application.Dtos.Kitchen.KitchenManager
{
    public class KitchenManagerDto:BaseDto, IKitchenManagerDto
    {
        public string NationalNumber { get; set; }
        public string Email { get; set; }
    }
}
