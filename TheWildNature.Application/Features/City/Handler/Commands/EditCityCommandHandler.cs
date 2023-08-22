using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Repositories.CityRepository;
using TheWildNature.Application.Dtos.City.Validators;
using TheWildNature.Application.Exceptions;
using TheWildNature.Application.Features.City.Request.Commands;

namespace TheWildNature.Application.Features.City.Handler.Commands
{
    public class EditCityCommandHandler : IRequestHandler<EditCityCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ICityRepository _cityRepository;
        public EditCityCommandHandler(IMapper mapper, ICityRepository cityRepository)
        {
            _mapper = mapper;
            _cityRepository = cityRepository;
        }
        public async Task<Unit> Handle(EditCityCommand request, CancellationToken cancellationToken)
        {
            var validator = new EditCityDtoValidator();
            var validationResult = await validator.ValidateAsync(request.CityDto);

            if (validationResult.IsValid == false)
            {
                throw new ValidationException(validationResult);
            }

            var city = await _cityRepository.GetByIdAsync(request.CityDto.Id);
            city = _mapper.Map(request.CityDto, city);
            await _cityRepository.UpdateAsync(city);

            return Unit.Value;
        }
    }
}
