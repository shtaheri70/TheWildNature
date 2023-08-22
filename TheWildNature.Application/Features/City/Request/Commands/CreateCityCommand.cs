using MediatR;
using TheWildNature.Application.Dtos.City;

namespace TheWildNature.Application.Features.City.Request.Commands
{
    public class CreateCityCommand : IRequest<int>
    {
        public CreateCityDto CreateCityDto { get; set; } = new CreateCityDto();
    }
}
