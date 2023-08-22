using TheWildNature.Application.Dtos.Common;
using TheWildNature.Application.Dtos.PlaceDetails;

namespace TheWildNature.Application.Dtos.User
{
    public class UpdatePlaceDetailsUserDto:BaseDto
    {
        public PlaceDetailsDto PlaceDetailsDto { get; set; }
    }
}
