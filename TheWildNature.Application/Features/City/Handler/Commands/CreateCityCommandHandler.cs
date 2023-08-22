using AutoMapper;
using MediatR;
using TheWildNature.Application.Contracts.Repositories.CityRepository;
using TheWildNature.Application.Dtos.City.Validators;
using TheWildNature.Application.Exceptions;
using TheWildNature.Application.Features.City.Request.Commands;

namespace TheWildNature.Application.Features.City.Handler.Commands
{
    public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ICityRepository _cityRepository;

        public CreateCityCommandHandler(IMapper mapper, ICityRepository cityRepository)
        {
            _mapper = mapper;
            _cityRepository = cityRepository;
        }
        public async Task<int> Handle(CreateCityCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateCityDtoValidator();
            var validationResult = await validator.ValidateAsync(request.CreateCityDto);

            if (validationResult.IsValid == false)
            {
                throw new ValidationException(validationResult);
            }
            var city = _mapper.Map<TheWildNature.Domain.Entities.City.City>(request.CreateCityDto);
            city = await _cityRepository.AddAsync(city);

            return city.Id;
        }
    }
}
