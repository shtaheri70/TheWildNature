using FluentValidation;
using FluentValidation.Validators;
using TheWildNature.Application.Dtos.Common.Validators;

namespace TheWildNature.Application.Dtos.City.Validators
{
    public class EditCityDtoValidator : AbstractValidator<CityDto>
    {
        public EditCityDtoValidator()
        {
            Include(new IBaseDtoValidator());

            Include(new ICityDtoValidator());
        }
    }
}
