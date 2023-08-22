using TheWildNature.Application.Dtos.Common;

namespace TheWildNature.Application.Dtos.City
{
    public class ProvinceDto : BaseDto, IProvinceDto
    {
        public string Name { get; set; }
    }
}
