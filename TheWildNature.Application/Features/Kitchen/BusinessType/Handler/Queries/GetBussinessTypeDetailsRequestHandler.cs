using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Application.Dtos.Kitchen.BussinesType;
using TheWildNature.Application.Exceptions;
using TheWildNature.Application.Features.Kitchen.BusinessType.Request.Queries;

namespace TheWildNature.Application.Features.Kitchen.BusinessType.Handler.Queries
{
    public class GetBussinessTypeDetailsRequestHandler : IRequestHandler<GetBussinessTypeDetailsRequset, BussinessTypeDto>
    {
        private readonly IMapper _mapper;
        private readonly IBussinessTypeRepository _bussinessTypeRepository;

        public GetBussinessTypeDetailsRequestHandler(IMapper mapper, IBussinessTypeRepository bussinessTypeRepository)
        {
            _mapper = mapper;
            _bussinessTypeRepository = bussinessTypeRepository;
        }
        public async Task<BussinessTypeDto> Handle(GetBussinessTypeDetailsRequset request, CancellationToken cancellationToken)
        {
            var bussinessTypeDetail =await _bussinessTypeRepository.GetByIdAsync(request.Id);
            if(bussinessTypeDetail == null)
            {
                throw new NotFoundException(nameof(bussinessTypeDetail), request.Id);
            }
            return _mapper.Map<BussinessTypeDto>(bussinessTypeDetail);
        }
    }
}
