using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Repositories.CityRepository;
using TheWildNature.Application.Dtos.City;
using TheWildNature.Application.Features.City.Request.Queries;

namespace TheWildNature.Application.Features.City.Handler.Queries
{
    public class GetCityListRequestHandler : IRequestHandler<GetCityListRequest, List<CityDto>>
    {
        private readonly IMapper _mapper;
        private readonly ICityRepository _cityRepository;

        public GetCityListRequestHandler(IMapper mapper, ICityRepository cityRepository)
        {
            _mapper = mapper;
            _cityRepository = cityRepository;
        }

        public async Task<List<CityDto>> Handle(GetCityListRequest request, CancellationToken cancellationToken)
        {
            var ListCities = await _cityRepository.GetAllAsync();
            return _mapper.Map<List<CityDto>>(ListCities);
        }
    }
}
