using TheWildNature.Application.Dtos.Common;
using TheWildNature.Application.Dtos.PlaceDetails;

namespace TheWildNature.Application.Dtos.User
{
    public class RegisterPlaceDetailsUserDto : BaseDto
    {
        public PlaceDetailsDto PlaceDetailsDto { get; set; }
    }
}
