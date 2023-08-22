using TheWildNature.Application.Dtos.Common;
using TheWildNature.Application.Dtos.PlaceDetails;

namespace TheWildNature.Application.Dtos.Kitchen.KitchenPlaceDetails
{
    public class EditKitchenPlaceDetailsDto:BaseDto,IPlaceDetailsDto
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string AddressDetails { get; set; }
        public string Phone { get; set; }
    }
}
