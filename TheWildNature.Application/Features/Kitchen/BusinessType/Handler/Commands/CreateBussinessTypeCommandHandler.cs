using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Application.Dtos.Kitchen.BussinesType.Validators;
using TheWildNature.Application.Exceptions;
using TheWildNature.Application.Features.Kitchen.BusinessType.Request.Commands;

namespace TheWildNature.Application.Features.Kitchen.BusinessType.Handler.Commands
{
    public class CreateBussinessTypeCommandHandler : IRequestHandler<CreateBussinessTypeCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IBussinessTypeRepository _bussinessTypeRepository;

        public CreateBussinessTypeCommandHandler(IMapper mapper, IBussinessTypeRepository bussinessTypeRepository)
        {
            _mapper = mapper;
            _bussinessTypeRepository = bussinessTypeRepository;
        }

        public async Task<int> Handle(CreateBussinessTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateBussinessTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.BussinessTypeDto);

            if (validationResult.IsValid == false)
            {
                throw new ValidationException(validationResult);
            }

            var bussinessType = _mapper.Map<TheWildNature.Domain.Entities.Kitchen.BusinessType>(request.BussinessTypeDto);
            bussinessType = await _bussinessTypeRepository.AddAsync(bussinessType);

            return bussinessType.Id;
        }
    }
}
