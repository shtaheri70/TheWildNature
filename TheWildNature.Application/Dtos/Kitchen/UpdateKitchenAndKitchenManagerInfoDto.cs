using TheWildNature.Application.Dtos.City;
using TheWildNature.Application.Dtos.Common;
using TheWildNature.Application.Dtos.Kitchen.KitchenManager;
using TheWildNature.Application.Dtos.PlaceDetails;
using TheWildNature.Application.Dtos.User;

namespace TheWildNature.Application.Dtos.Kitchen
{
    public class UpdateKitchenAndKitchenManagerInfoDto : BaseDto,
        IKitchenDto, IUserFullNameDto,
        IKitchenManagerDto, IPlaceDetailsDto

    {
        public string KitchenName { get; set; }
        public int BusinessTypeId { get; set; }
        public string BusinessTypeTitle { get; set; }

        public string Name { get; set; }
        public string Family { get; set; }

        public int KitchenManagerId { get; set; }
        public int UserId { get; set; }
        public string NationalNumber { get; set; }
        public string Email { get; set; }

        public int CityId { get; set; }
        public int PlaceDetailsId { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string AddressDetails { get; set; }
        public string Phone { get; set; }



    }
}
