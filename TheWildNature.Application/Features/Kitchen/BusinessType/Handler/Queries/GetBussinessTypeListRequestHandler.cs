using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Application.Dtos.Kitchen.BussinesType;
using TheWildNature.Application.Features.Kitchen.BusinessType.Request.Queries;

namespace TheWildNature.Application.Features.Kitchen.BusinessType.Handler.Queries
{
    public class GetBussinessTypeListRequestHandler : IRequestHandler<GetBussinessTypeListRequest, List<BussinessTypeDto>>
    {
        private readonly IMapper _mapper;
        private readonly IBussinessTypeRepository _bussinessTypeRepository;

        public GetBussinessTypeListRequestHandler(IMapper mapper, IBussinessTypeRepository bussinessTypeRepository)
        {
            _mapper = mapper;
            _bussinessTypeRepository = bussinessTypeRepository;
        }
        public async Task<List<BussinessTypeDto>> Handle(GetBussinessTypeListRequest request, CancellationToken cancellationToken)
        {
            var ListBussinessTypes = await _bussinessTypeRepository.GetAllAsync();
            return _mapper.Map<List<BussinessTypeDto>>(ListBussinessTypes);
        }
    }
}
