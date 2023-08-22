using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Application.Dtos.Kitchen.BussinesType.Validators;
using TheWildNature.Application.Exceptions;
using TheWildNature.Application.Features.Kitchen.BusinessType.Request.Commands;

namespace TheWildNature.Application.Features.Kitchen.BusinessType.Handler.Commands
{
    public class EditBussinessTypeCommandHandler : IRequestHandler<EditBussinessTypeCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IBussinessTypeRepository _bussinessTypeRepository;

        public EditBussinessTypeCommandHandler(IMapper mapper, IBussinessTypeRepository bussinessTypeRepository)
        {
            _mapper = mapper;
            _bussinessTypeRepository = bussinessTypeRepository;
        }
        public async Task<Unit> Handle(EditBussinessTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new EditBussinessTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.BussinessTypeDto);

            if (validationResult.IsValid == false)
            {
                throw new ValidationException(validationResult);
            }

            var BussinessType = await _bussinessTypeRepository.GetByIdAsync(request.BussinessTypeDto.Id);
            BussinessType = _mapper.Map(request.BussinessTypeDto, BussinessType);
            await _bussinessTypeRepository.UpdateAsync(BussinessType);

           

            return Unit.Value;
        }
    }
}
