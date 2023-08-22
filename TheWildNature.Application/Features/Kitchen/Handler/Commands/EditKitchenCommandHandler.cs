using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Application.Dtos.Kitchen.Validators;
using TheWildNature.Application.Exceptions;
using TheWildNature.Application.Features.Kitchen.Request.Commands;

namespace TheWildNature.Application.Features.Kitchen.Handler.Commands
{
    public class EditKitchenCommandHandler : IRequestHandler<EditKitchenCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IKitchenRepository _kitchenRepository;
        public EditKitchenCommandHandler(IMapper mapper, IKitchenRepository kitchenRepository)
        {
            _mapper = mapper;
            _kitchenRepository = kitchenRepository;
        }
        public async Task<Unit> Handle(EditKitchenCommand request, CancellationToken cancellationToken)
        {
            var validator = new KitchenDtoValidator();
            var validationResult = await validator.ValidateAsync(request.KitchenDto);

            if (validationResult.IsValid == false)
            {
                throw new ValidationException(validationResult);
            }

            var kitchen = _mapper.Map<TheWildNature.Domain.Entities.Kitchen.Kitchen>(request.KitchenDto);
            await _kitchenRepository.AttachAsync(kitchen);

            return Unit.Value;
        }
    }
}
