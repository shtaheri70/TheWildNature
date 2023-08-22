using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Application.Dtos.Kitchen;
using TheWildNature.Application.Exceptions;
using TheWildNature.Application.Features.Kitchen.Request.Queries;

namespace TheWildNature.Application.Features.Kitchen.Handler.Queries
{
    public class GetKitchenRequestHandler : IRequestHandler<GetKitchenRequest, KitchenDto>
    {
        private readonly IKitchenRepository _kitchenRepository;
        private readonly IMapper _mapper;
        public GetKitchenRequestHandler(IKitchenRepository kitchenRepository,
                                        IMapper mapper)
        {
            _kitchenRepository = kitchenRepository;
        }
        public async Task<KitchenDto> Handle(GetKitchenRequest request, CancellationToken cancellationToken)
        {
            var kitchen = await _kitchenRepository.GetByIdAsync(request.KitchenId);
            if (kitchen == null)
            {
                throw new NotFoundException(nameof(kitchen), request.KitchenId);
            }
            return _mapper.Map<KitchenDto>(kitchen);
        }
    }
}
