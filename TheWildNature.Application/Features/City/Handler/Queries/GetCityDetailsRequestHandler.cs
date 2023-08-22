using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Repositories.CityRepository;
using TheWildNature.Application.Dtos.City;
using TheWildNature.Application.Exceptions;
using TheWildNature.Application.Features.City.Request.Queries;

namespace TheWildNature.Application.Features.City.Handler.Queries
{
    public class GetCityDetailsRequestHandler : IRequestHandler<GetCityDetailsRequest, CityDto>
    {
        private readonly IMapper _mapper;
        private readonly ICityRepository _cityRepository;

        public GetCityDetailsRequestHandler(IMapper mapper, ICityRepository cityRepository)
        {
            _mapper = mapper;
            _cityRepository = cityRepository;
        }

        public async Task<CityDto> Handle(GetCityDetailsRequest request, CancellationToken cancellationToken)
        {
            var city = await _cityRepository.GetByIdAsync(request.Id);
            if (city == null)
            {
                throw new NotFoundException(nameof(city), request.Id);
            }

            return _mapper.Map<CityDto>(city);
        }
    }
}
