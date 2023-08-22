using TheWildNature.Application.Dtos.Common;
using TheWildNature.Application.Dtos.PlaceDetails;

namespace TheWildNature.Application.Dtos.User
{
    public class ListPlacesDetailsUserDto:BaseDto
    {
        public string AddressDetails { get; set; }
        public bool IsDefault { get; set; }
    }
}
