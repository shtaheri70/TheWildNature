using FluentValidation;

namespace TheWildNature.Application.Dtos.City.Validators
{
    public class CreateCityDtoValidator : AbstractValidator<CreateCityDto>
    {
        public CreateCityDtoValidator()
        {
            RuleFor(p => p.ProvinceId)
             .NotEmpty().WithMessage("{PropertyName} is required")
             .NotNull();

            Include(new ICityDtoValidator());
        }
    }
}
