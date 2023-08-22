using TheWildNature.Application.Dtos.Common;

namespace TheWildNature.Application.Dtos.City
{
    public class CityDto:BaseDto,ICityDto
    {
        public string CityName { get; set; }
    }
}
