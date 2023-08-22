using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Application.Exceptions;
using TheWildNature.Application.Features.Kitchen.BusinessType.Request.Commands;

namespace TheWildNature.Application.Features.Kitchen.BusinessType.Handler.Commands
{
    public class DeleteBussinessCommandHandler:IRequestHandler<DeleteBussinessTypeCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IBussinessTypeRepository _bussinessTypeRepository;

        public DeleteBussinessCommandHandler(IMapper mapper, IBussinessTypeRepository bussinessTypeRepository)
        {
            _mapper = mapper;
            _bussinessTypeRepository = bussinessTypeRepository;
        }
        public async Task<Unit> Handle(DeleteBussinessTypeCommand request, CancellationToken cancellationToken)
        {
            var bussinessType = await _bussinessTypeRepository.GetByIdAsync(request.Id);

            if (bussinessType == null)
            {
                throw new NotFoundException(nameof(bussinessType), request.Id);
            }

            await _bussinessTypeRepository.DeleteAsync(bussinessType);

            return Unit.Value;
        }
    }
}
