using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Infrastructure;
using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Application.Dtos.Kitchen.Validators;
using TheWildNature.Application.Exceptions;
using TheWildNature.Application.Features.Kitchen.Request.Commands;
using TheWildNature.Application.Response;

namespace TheWildNature.Application.Features.Kitchen.Handler.Commands
{
    public class CreateKitchenBasicInfoCommandHandler : IRequestHandler<CreateKitchenBasicInfoCommand, BaseCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IKitchenRepository _kitchenRepository;
        private readonly ISMSSender _smsSender;

        public CreateKitchenBasicInfoCommandHandler(IMapper mapper,
            IKitchenRepository kitchenRepository,
            ISMSSender smsSender)
        {
            _mapper = mapper;
            _kitchenRepository = kitchenRepository;
            _smsSender = smsSender;
        }

        public async Task<BaseCommandResponse> Handle(CreateKitchenBasicInfoCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new RegisterKitchenBasicInfoDtoValidator();
            var validationResult = await validator.ValidateAsync(request.RegisterKitchenBaiscInfoDto);

            if (validationResult.IsValid == false)
            {
                //throw new ValidationException(validationResult);
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }

            var kitchen = _mapper.Map<TheWildNature.Domain.Entities.Kitchen.Kitchen>(request.RegisterKitchenBaiscInfoDto);

            try
            {
                //Register kitchen, kitchen Managger , user
                var activeCode = await _kitchenRepository.AddBasicInformationAsync(kitchen);

                response.Success = true;
                response.Message = "Creation Succesdsful";
                response.Id = kitchen.Id;

                #region Send Activation Email
                //await _smsSender.SendLookupSMS(
                //    request.RegisterKitchenBaiscInfoDto.Mobile,
                //    "کد تایید ثبت نام",
                //    activeCode);
                #endregion


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }
    }
}
