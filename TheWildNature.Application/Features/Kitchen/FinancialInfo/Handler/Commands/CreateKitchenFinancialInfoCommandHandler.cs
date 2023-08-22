using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Infrastructure;
using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Application.Dtos.Kitchen.FinancialInfo.Validators;
using TheWildNature.Application.Exceptions;
using TheWildNature.Application.Features.Kitchen.FinancialInfo.Request.Commands;
using TheWildNature.Application.Security;

namespace TheWildNature.Application.Features.Kitchen.FinancialInfo.Handler.Commands
{
    public class CreateKitchenFinancialInfoCommandHandler : IRequestHandler<CreateKitchenFinancialInfoCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IKitchenFinancialInfoRepository _kitchenFinancialInfoRepository;
        private readonly IFilesServise _fileServise;
        private readonly IKitchenRepository _kitchenRepository;

        public CreateKitchenFinancialInfoCommandHandler(IMapper mapper,
            IKitchenFinancialInfoRepository kitchenFinancialInfoRepository,
            IKitchenRepository kitchenRepository,
            IFilesServise fileServise)
        {
            _mapper = mapper;
            _kitchenFinancialInfoRepository = kitchenFinancialInfoRepository;
            _kitchenRepository = kitchenRepository;
            _fileServise = fileServise;
        }

        public async Task<Unit> Handle(CreateKitchenFinancialInfoCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateKitchenFinancialInfoDtoValidator();
            var validationResult = await validator.ValidateAsync(request.KitchenFinancialInfoDto);

            if (validationResult.IsValid == false)
            {
                throw new ValidationException(validationResult);
            }

            var kitchenFinancialInfo = _mapper.Map<TheWildNature.Domain.Entities.Kitchen.KitchenFinancialInfo>(request.KitchenFinancialInfoDto);
           

            var financialFile = request.KitchenFinancialInfoDto.BusinessLicenseFile;
            kitchenFinancialInfo.BusinessLicenseFileName = await _fileServise.AddFileAsync(financialFile,
                                                                 "KitchenFinancialInfoFiles/BusinessLicenseFiles");

            var cardFile = request.KitchenFinancialInfoDto.CardFile;
            kitchenFinancialInfo.CardFileName = await _fileServise.AddFileAsync(cardFile,
                                                                 "KitchenFinancialInfoFiles/CardFiles");

           
            kitchenFinancialInfo = await _kitchenFinancialInfoRepository.AddAsync(kitchenFinancialInfo);
            
          
            await _kitchenFinancialInfoRepository.AttachAsync(kitchenFinancialInfo);

            //save financialid to kitchen
            #region update kitche
            var kitchen = await _kitchenRepository.GetByIdAsync(request.KitchenId);
            kitchen.KitchenFinancialInfoId = kitchenFinancialInfo.Id;
          
            await _kitchenRepository.AttachAsync(kitchen);
            #endregion


            return Unit.Value;
        }
    }
}
