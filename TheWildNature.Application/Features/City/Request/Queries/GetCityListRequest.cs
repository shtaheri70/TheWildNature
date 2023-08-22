using MediatR;
using TheWildNature.Application.Dtos.City;

namespace TheWildNature.Application.Features.City.Request.Queries
{
    public class GetCityListRequest : IRequest<List<CityDto>>
    {
        public int ProvinceId { get; set; }
    }
}
