using MediatR;
using TheWildNature.Application.Dtos.City;

namespace TheWildNature.Application.Features.City.Request.Commands
{
    public class EditCityCommand : IRequest<Unit>
    {
        public CityDto CityDto { get; set; }
    }
}
