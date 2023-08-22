using MediatR;
using TheWildNature.Application.Contracts.Repositories.CityRepository;
using TheWildNature.Application.Exceptions;
using TheWildNature.Application.Features.City.Request.Commands;

namespace TheWildNature.Application.Features.City.Handler.Commands
{
    public class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand,Unit>
    {
        private readonly ICityRepository _cityRepository;
        public DeleteCityCommandHandler(ICityRepository cityRepository)
        {
           _cityRepository = cityRepository;   
        }

        public async Task<Unit> Handle(DeleteCityCommand request, CancellationToken cancellationToken)
        {
            var city = await _cityRepository.GetByIdAsync(request.Id);

            if (city == null)
            {
                throw new NotFoundException(nameof(city), request.Id);
            }

            await _cityRepository.DeleteAsync(city);

            return Unit.Value;
        }
    }
}
