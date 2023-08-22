using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Application.Dtos.Kitchen.KitchenManager;
using TheWildNature.Application.Features.Kitchen.KitchenManager.Request.Queries;

namespace TheWildNature.Application.Features.Kitchen.KitchenManager.Handler.Queries
{
    public class GetKitchenManagerRequestHandler : IRequestHandler<GetKitchenManagerRequest, KitchenManagerDto>
    {
        private readonly IKitchenManagerRepository _kitchenManagerRepository;
        private readonly IMapper _mapper;
        public GetKitchenManagerRequestHandler(IKitchenManagerRepository kitchenManagerRepository, IMapper mapper)
        {
            _kitchenManagerRepository = kitchenManagerRepository;
            _mapper = mapper;
        }
        public async Task<KitchenManagerDto> Handle(GetKitchenManagerRequest request, CancellationToken cancellationToken)
        {
            var kitchenManager = await _kitchenManagerRepository.GetKitchenManagerWithUserId(request.UserId);

            return _mapper.Map<KitchenManagerDto>(kitchenManager);
        }
    }
}
