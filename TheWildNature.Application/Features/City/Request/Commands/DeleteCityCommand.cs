using MediatR;

namespace TheWildNature.Application.Features.City.Request.Commands
{
    public class DeleteCityCommand:IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
