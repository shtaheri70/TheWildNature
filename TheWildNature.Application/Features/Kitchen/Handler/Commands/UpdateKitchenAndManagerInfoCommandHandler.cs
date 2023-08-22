using AutoMapper;
using Azure.Core;
using MediatR;
using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Application.Contracts.Repositories.PlaceDetailsRepository;
using TheWildNature.Application.Dtos.Kitchen.KitchenManager;
using TheWildNature.Application.Dtos.Kitchen.KitchenManager.Validators;
using TheWildNature.Application.Dtos.PlaceDetails;
using TheWildNature.Application.Dtos.PlaceDetails.Validators;
using TheWildNature.Application.Exceptions;
using TheWildNature.Application.Features.Kitchen.Request.Commands;
using TheWildNature.Domain.Entities.PlaceDetails;

namespace TheWildNature.Application.Features.Kitchen.Handler.Commands
{
    public class UpdateKitchenAndManagerInfoCommandHandler : IRequestHandler<UpdateKitchenAndManagerInfoCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IKitchenRepository _kitchenRepository;
        private readonly IKitchenManagerRepository _kitchenManagerRepository;
        private readonly IPlaceDetailsRepository _placeDetailsRepository;
        public UpdateKitchenAndManagerInfoCommandHandler(IMapper mapper,
            IKitchenRepository kitchenRepository,
            IKitchenManagerRepository kitchenManagerRepository,
            IPlaceDetailsRepository placeDetailsRepository
            )
        {
            _mapper = mapper;
            _kitchenRepository = kitchenRepository;
            _kitchenManagerRepository = kitchenManagerRepository;
            _placeDetailsRepository = placeDetailsRepository;
        }
        public async Task<Unit> Handle(UpdateKitchenAndManagerInfoCommand request, CancellationToken cancellationToken)
        {
            #region update kitchen Manager

            await UpdateKitchenManager(request);

            #endregion

            #region create kitchen PlaceDetails

            int kitchenPlaceDetailsId =await CreateKitchenPlaceDetails(request);

            #endregion

            #region update kitche
            var kitchen = await _kitchenRepository.GetByIdAsync(request.KitchenDto.Id);
            kitchen.PlaceDetailsId = kitchenPlaceDetailsId;
            kitchen.CityId = request.KitchenDto.CityId;

            await _kitchenRepository.AttachAsync(kitchen);
            #endregion

            return Unit.Value;
        }

        private async Task UpdateKitchenManager(UpdateKitchenAndManagerInfoCommand request)
        {
            var kitchenManagerDto = _mapper.Map<KitchenManagerDto>(request.KitchenDto);

            var validatorKM = new IKitchenManagerDtoValidator();
            var validationResultKM = await validatorKM.ValidateAsync(kitchenManagerDto);

            if (validationResultKM.IsValid == false)
            {
                throw new ValidationException(validationResultKM);
            }
            var kitchenManager = await _kitchenManagerRepository.GetByIdAsync(request.KitchenDto.KitchenManagerId);

            _mapper.Map(kitchenManagerDto, kitchenManager);
            await _kitchenManagerRepository.AttachAsync(kitchenManager);
        }

        private async Task<int> CreateKitchenPlaceDetails(UpdateKitchenAndManagerInfoCommand request) 
        {
            var kitchenPlaceDetailsDto = _mapper.Map<KitchenPlaceDetailsDto>(request.KitchenDto);

            var validatorPD = new IPlaceDetailsDtoValidator();
            var validationResultOD = await validatorPD.ValidateAsync(kitchenPlaceDetailsDto);

            if (validationResultOD.IsValid == false)
                throw new ValidationException(validationResultOD);
            var kitchenPlaceDetails = _mapper.Map<PlaceDetails>(kitchenPlaceDetailsDto);
            kitchenPlaceDetails.IsDefault = true;
            kitchenPlaceDetails.Title = "";

            kitchenPlaceDetails = await _placeDetailsRepository.AddAsync(kitchenPlaceDetails);

            return kitchenPlaceDetails.Id;
        }

    }
}
