using TheWildNature.Application.Dtos.Kitchen.KitchenManager;
using TheWildNature.Application.Dtos.PlaceDetails;
using TheWildNature.Application.Dtos.User;

namespace TheWildNature.Application.Dtos.Kitchen
{
    public class CreatePlaceDetailsKitchenInfoDto:IPlaceDetailsDto
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string AddressDetails { get; set; }
        public string Phone { get; set; }

    }
}
