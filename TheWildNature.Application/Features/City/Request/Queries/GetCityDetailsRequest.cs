using MediatR;
using TheWildNature.Application.Dtos.City;

namespace TheWildNature.Application.Features.City.Request.Queries
{
    public class GetCityDetailsRequest : IRequest<CityDto>
    {
        public int Id { get; set; }
    }
}
