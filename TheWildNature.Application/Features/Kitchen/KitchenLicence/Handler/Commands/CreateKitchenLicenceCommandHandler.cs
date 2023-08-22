using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Infrastructure;
using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Application.Dtos.Kitchen.KitchenLicense.Validators;
using TheWildNature.Application.Exceptions;
using TheWildNature.Application.Features.Kitchen.KitchenLicence.Request.Commands;
using TheWildNature.Domain.Entities.Kitchen;

namespace TheWildNature.Application.Features.Kitchen.KitchenLicence.Handler.Commands
{
    public class CreateKitchenLicenceCommandHandler : IRequestHandler<CreateKitchenLicenceCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IKitchenLicenceRepository _kitchenLicenceRepository;
        private readonly IKitchenRepository _kitchenRepository;
        private readonly IFilesServise _fileServise;


        public CreateKitchenLicenceCommandHandler(IMapper mapper,
            IKitchenLicenceRepository kitchenLicenceRepository,
            IKitchenRepository kitchenRepository,
        IFilesServise fileServise)
        {
            _mapper = mapper;
            _kitchenLicenceRepository = kitchenLicenceRepository;
            _kitchenRepository = kitchenRepository;
            _fileServise = fileServise;
        }

        public async Task<Unit> Handle(CreateKitchenLicenceCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateKitchenLicenceDtoValidaor();
            var validationResult =await validator.ValidateAsync(request.CreateKitchenLicenseDto);

            if (validationResult.IsValid == false)
            {
                throw new ValidationException(validationResult);
            }

            var kitchenLicence = _mapper.Map<TheWildNature.Domain.Entities.Kitchen.KitchenLicence>(request.CreateKitchenLicenseDto);

            var LicenseFile = request.CreateKitchenLicenseDto.LicenseFile;
            kitchenLicence.LicenseFileName = await _fileServise.AddFileAsync(LicenseFile,
                                                                "KitchenLicenceFiles/LicenceFiles");

            kitchenLicence = await _kitchenLicenceRepository.AddAsync(kitchenLicence);

            //save financialid to kitchen
            #region update kitche
            var kitchen = await _kitchenRepository.GetByIdAsync(request.KitchenId);
            kitchen.PlaceDetailsId = kitchenLicence.Id;

            await _kitchenRepository.AttachAsync(kitchen);
            #endregion

            return Unit.Value;
        }
    }
}
