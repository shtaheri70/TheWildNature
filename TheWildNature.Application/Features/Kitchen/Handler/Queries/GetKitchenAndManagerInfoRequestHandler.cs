using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Infrastructure;
using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Application.Dtos.Kitchen;
using TheWildNature.Application.Dtos.Kitchen.BussinesType;
using TheWildNature.Application.Exceptions;
using TheWildNature.Application.Features.Kitchen.Request.Queries;

namespace TheWildNature.Application.Features.Kitchen.Handler.Queries
{
    public class GetKitchenAndManagerInfoRequestHandler : IRequestHandler< GetKitchenAndManagerInfoRequset,
        UpdateKitchenAndKitchenManagerInfoDto>
    {
        private readonly IMapper _mapper;
        private readonly IKitchenRepository _kitchenRepository;

        public GetKitchenAndManagerInfoRequestHandler(IMapper mapper,
           IKitchenRepository kitchenRepository)
        {
            _mapper = mapper;
            _kitchenRepository = kitchenRepository;
        }
        public async Task<UpdateKitchenAndKitchenManagerInfoDto> Handle(GetKitchenAndManagerInfoRequset request, CancellationToken cancellationToken)
        {
            var kitchenInfo = await _kitchenRepository.GetKitchenAndKitchenManagerInfoWithUserId(request.UserId);

            if (kitchenInfo == null)
            {
                throw new NotFoundException(nameof(kitchenInfo), request.UserId);
            }
            return _mapper.Map<UpdateKitchenAndKitchenManagerInfoDto>(kitchenInfo); 
        }
    }
}
