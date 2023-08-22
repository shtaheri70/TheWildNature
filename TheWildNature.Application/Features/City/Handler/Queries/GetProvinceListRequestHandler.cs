using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Repositories.CityRepository;
using TheWildNature.Application.Dtos.City;
using TheWildNature.Application.Features.City.Request.Queries;

namespace TheWildNature.Application.Features.City.Handler.Queries
{
    public class GetProvinceListRequestHandler : IRequestHandler<GetProvinceListRequest, List<ProvinceDto>>
    {
        private readonly IProvinceRepository _provinceRepository;
        private readonly IMapper _mapper;
        public GetProvinceListRequestHandler(IProvinceRepository provinceRepository, IMapper mapper)
        {
            _provinceRepository = provinceRepository;
            _mapper = mapper;
        }
        public async Task<List<ProvinceDto>> Handle(GetProvinceListRequest request, CancellationToken cancellationToken)
        {
            var ProvinceList = await _provinceRepository.GetAllAsync();
            return _mapper.Map<List<ProvinceDto>>(ProvinceList);
        }
    }
}
